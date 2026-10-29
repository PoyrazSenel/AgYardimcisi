using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace AgYardimcisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void getirBtn_Click(object sender, EventArgs e)
        {
            string yerelIp = "";
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    yerelIp = ip.ToString();
                    break;
                }
            }
            txtip.Text = yerelIp;


            string aktifDns = "Bulunamadı";
            string adaptorAdi = "Bilinmiyor";

            foreach(NetworkInterface adaptor in NetworkInterface.GetAllNetworkInterfaces())
            {
                if(adaptor.OperationalStatus==OperationalStatus.Up && adaptor.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    IPInterfaceProperties ozellik=adaptor.GetIPProperties();
                    if(ozellik.GatewayAddresses.Count > 0)
                    {
                        foreach(IPAddress dns in ozellik.DnsAddresses)
                        {
                            if (dns.AddressFamily == AddressFamily.InterNetwork)
                            {
                                aktifDns = dns.ToString();
                                adaptorAdi = adaptor.Name;
                                break;
                            }
                        }
                    }
                }
                if (aktifDns != "Bulunamadı")
                {
                    break;
                }
            }
            txtdns.Text = aktifDns.ToString();
            txtKart.Text=adaptorAdi.ToString();
        }

        private void BaglantiTestBtn_Click(object sender, EventArgs e)
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                MessageBox.Show("BAĞLANTI YOK: Bilgisayar hiçbir ağa bağlı değil (Kablo kopuk / Wi-Fi kapalı).");
                return; 
            }

            
            try
            {
                Ping pingTest = new Ping();
                PingReply cevap = pingTest.Send("8.8.8.8", 3000);

                if (cevap.Status == IPStatus.Success)
                {
                    MessageBox.Show($"İnternet Aktif! Gecikme süresi: {cevap.RoundtripTime} ms");
                }
                else
                {
              
                    MessageBox.Show($"Ağa bağlısınız ancak İNTERNET YOK. Sebep: {cevap.Status}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Test sırasında hata oluştu: " + ex.Message);
            }
        }

  

  

        private async void RaporYazbtn_Click_1(object sender, EventArgs e)
        {
    
            string rapor = "=== SİSTEM AĞ DURUM RAPORU ===\r\n";
            rapor += $"Tarih: {DateTime.Now}\r\n\r\n";

            rapor += $"Bilgisayar Adı: {Dns.GetHostName()}\r\n";

      
            string aktifAdaptor = "Bağlantı Yok";
            string yerelIp = "Bulunamadı";
            string aktifDns = "Bulunamadı";

            foreach (NetworkInterface adaptor in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (adaptor.OperationalStatus == OperationalStatus.Up &&
                    adaptor.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    IPInterfaceProperties ozellikler = adaptor.GetIPProperties();

                    if (ozellikler.GatewayAddresses.Count > 0)
                    {
                        aktifAdaptor = adaptor.Name;

                        foreach (UnicastIPAddressInformation ip in ozellikler.UnicastAddresses)
                        {
                            if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                            {
                                yerelIp = ip.Address.ToString();
                                break;
                            }
                        }

                        foreach (IPAddress dns in ozellikler.DnsAddresses)
                        {
                            if (dns.AddressFamily == AddressFamily.InterNetwork)
                            {
                                aktifDns = dns.ToString();
                                break;
                            }
                        }
                        break;
                    }
                }
            }

            rapor += $"Aktif Ağ Kartı: {aktifAdaptor}\r\n";
            rapor += $"Yerel IP (IPv4): {yerelIp}\r\n";
            rapor += $"Aktif DNS: {aktifDns}\r\n";

      
            rapor += "İnternet Durumu: ";
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                try
                {
                    Ping ping = new Ping();
                    PingReply cevap = ping.Send("8.8.8.8", 2000);
                    rapor += cevap.Status == IPStatus.Success ? $"Bağlı (Gecikme: {cevap.RoundtripTime} ms)\r\n" : $"Sorunlu ({cevap.Status})\r\n";
                }
                catch { rapor += "Ping Hatası\r\n"; }
            }
            else { rapor += "Fiziksel Bağlantı Yok!\r\n"; }

      
            rapor += "Dış IP Adresi: ";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(3);
                    string disIp = await client.GetStringAsync("https://api.ipify.org");
                    rapor += $"{disIp}\r\n";
                }
            }
            catch { rapor += "Alınamadı\r\n"; }

            rapor += "\r\n==============================";

       

            SaveFileDialog kaydetPenceresi = new SaveFileDialog();
            kaydetPenceresi.Title = "Raporu Nereye Kaydetmek İstersiniz?";
            kaydetPenceresi.Filter = "Metin Belgesi (*.txt)|*.txt"; 
            kaydetPenceresi.FileName = "Ag_Durum_Raporu.txt"; 

           
            if (kaydetPenceresi.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(kaydetPenceresi.FileName, rapor);

                MessageBox.Show("Rapor başarıyla metin belgesi olarak kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide(); 
                notifyIcon1.Visible = true; 
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContextMenuStrip sagTikMenusu = new ContextMenuStrip();

            sagTikMenusu.Items.Add("Göster", null, Goster_Click);
            sagTikMenusu.Items.Add("Çıkış Yap", null, Cikis_Click);

           
            notifyIcon1.ContextMenuStrip = sagTikMenusu;
        }
        private void Goster_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Application.Exit();
        }
    }
}

