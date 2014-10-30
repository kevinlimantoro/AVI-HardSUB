#region Using directives
using AviFile;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
#endregion


namespace AVI_HardSUB
{
    public partial class MainForm : Form
    {
        private delegate void SimpleDelegate();

        private AviPlayer player;
        private EditableVideoStream editableStream;
        string path;
        public MainForm()
        {
            InitializeComponent();
        }

        private String GetFileName(String filter)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = filter;
            dlg.RestoreDirectory = true;
            if (txtAviFile.Text.Length > 0)
            {
                dlg.InitialDirectory = txtAviFile.Text.Substring(0, txtAviFile.Text.LastIndexOf("\\") + 1);
            }
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                return dlg.FileName;
            }
            else
            {
                return null;
            }
        }

        private void Hardsub()
        {
            string minstr, secstr, imgtime; int row,i,sec,min;bool found=false;
            if (System.IO.File.Exists(txtAviFile.Text))
            {
                
                    path = txtAviFile.Text.Substring(0, txtAviFile.Text.Length - 4);
                    path = path + "3.avi";
                    
                    AviManager newFile = new AviManager(path,false);
                    try{
                    AviManager existvideo = new AviManager(txtAviFile.Text, true);
                    VideoStream videoStream = existvideo.GetVideoStream();

                    videoStream.GetFrameOpen();
                    Bitmap bmp = videoStream.GetBitmap(0);

                    VideoStream newStream = newFile.AddVideoStream(true, videoStream.FrameRate, bmp);
                        int x, y;
                        x = videoStream.Width / 100 * 15;
                        y = videoStream.Height / 100 * 95;
                        string lirik = ""; string nxtime; bool OkChange;
                        int Pstring,IndeksSubtitle,indeks,nextsubframe,colorchange,count;
                        indeks = 0;
                        IndeksSubtitle = 0;
                        count = 0;
                        colorchange = 0;
                        OkChange = false;

                    for (int n = 1;
                                 n <= videoStream.CountFrames; n++)
                    {
                        sec = n / (int)videoStream.FrameRate;
                        min = sec / 60;
                        if (sec >= 60)
                        {
                            sec = sec % 60;
                            minstr = min.ToString();
                            secstr = sec.ToString();
                        }
                        else
                        {
                            minstr = min.ToString();
                            secstr = sec.ToString();
                        }

                        if (minstr.Length < 2)
                        {
                            minstr = "0" + minstr;
                        }

                        if (secstr.Length < 2)
                        {
                            secstr = "0" + secstr;
                        }

                        imgtime = minstr + ":" + secstr;

                        for (i = 0; i < dataGridView1.RowCount - 1; i++)
                        {
                            if (imgtime == dataGridView1.Rows[i].Cells[0].Value.ToString().Substring(1, 5)&&indeks!=i)
                            {
                                lirik = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                Pstring = lirik.Length;
                                IndeksSubtitle = 0;
                                indeks = i;
                                colorchange = 15;
                                nxtime = dataGridView1.Rows[i+1].Cells[0].Value.ToString().Substring(1,5);
                                nextsubframe = Convert.ToInt32(nxtime.Substring(0, 2)) * 60 * (int)videoStream.FrameRate;
                                nextsubframe = nextsubframe + (Convert.ToInt32(nxtime.Substring(3, 2)) * (int)videoStream.FrameRate);
                                if (Pstring > 0)
                                { colorchange = (nextsubframe - n) / Pstring; OkChange = true; count = 0; }
                                else if(Pstring==0)
                                { OkChange = false; count = 0; }
                                found = true;
                            }
                        }
                        if (found == true)
                        {
                            Bitmap bmp2;
                            bmp2 = videoStream.GetBitmap(n);
                            Graphics g;
                            g = Graphics.FromImage(bmp2);
                            g.DrawString(lirik, new Font("Tahoma", 18), Brushes.NavajoWhite, new PointF(x, y));
                            g.DrawString(lirik.Substring(0, IndeksSubtitle), new Font("Tahoma", 18), Brushes.DeepSkyBlue, new PointF(x, y));
                            //cari supaya isa bold, ato color chooser;
                            newStream.AddFrame(bmp2);
                            bmp2.Dispose();
                            g.Dispose();
                            count++;

                        }
                        if(found==false)
                        {
                            Bitmap bmp2;
                            bmp2 = videoStream.GetBitmap(n);
                            newStream.AddFrame(bmp2);
                            bmp2.Dispose();
                        }
                        
                        if (count == colorchange&&found==true&&OkChange==true)
                        {
                            if (IndeksSubtitle < lirik.Length)
                            {
                                IndeksSubtitle++;
                            }
                                count = 0;
                        }

                        
                        

                    }
                        
                    
                  
                    videoStream.GetFrameClose();
                    existvideo.Close();
                    

                }
                catch (Exception ex)
                {   
                    newFile.Close();
                    //throw ex;
                }
                 string path3 = path.Substring(0, path.Length - 3);
                 path3 = path3 + "wav";
                AviManager newFile2 = new AviManager(path, true);
                newFile2.AddAudioStream(path3, 0);
                newFile2.Close();

            }
        }

        private void ExtractSound()
        {
            
            string path = txtAviFile.Text;
            AviManager avi = new AviManager(path, true);
            AudioStream temp = avi.GetWaveStream();
            path = path.Substring(0, path.Length - 4);
            path = path + "3.wav";
            temp.ExportStream(path);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String filename=GetFileName("Videos (*.mkv)|*.avi;*.mpe;*.mkv");
            if (filename != null) {
                txtAviFile.Text = filename;
                
                

                mediaplayer.URL = txtAviFile.Text; 
               
                path=txtAviFile.Text.Substring(0, txtAviFile.Text.Length - 3);
                path = path + "lrc";
                if (System.IO.File.Exists(path))
                {
                    TextReader SubLrc = new StreamReader(path);
                    string ts;
                    ts = "a";
                    while (ts!=null)
                    {     
                        ts = SubLrc.ReadLine();
                        if(ts!=null)
                        {
                            if (ts.Length>8&&ts.Substring(9, 1) == "]")
                            {
                                dataGridView1.Rows.Add(ts.Substring(0, 10), ts.Substring(10));
                            }
                        } timer1.Enabled = true;
                    } 
                    //mediaplayer.closedCaption.SAMIFileName = path;
                }
                else 
                {
                    dataGridView1.Rows.Add("No Subtitle Found", "-") ;
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            string a,b;int i;
            a = mediaplayer.Ctlcontrols.currentPosition.ToString();
            b = mediaplayer.Ctlcontrols.currentPositionString;
            if (a != "0")
            { a = a.Substring(a.IndexOf('.'), 3); }
            a = b+a ;
            button1.Text = a;
            for (i = 0; i < dataGridView1.RowCount-1; i++)
            {
                if (a.Length>=8&&dataGridView1.Rows[i].Cells[0].Value.ToString().Length>=8)
                {
                    if (a.Substring(0, 7) == dataGridView1.Rows[i].Cells[0].Value.ToString().Substring(1, 7))
                    {
                        label2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[i].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1[0, i];
                    }
                }
            }
            
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            textBox1.Text = "[" + button1.Text + "]";
            mediaplayer.Ctlcontrols.pause();

                /*string a=dataGridView1.Rows[0].Cells[1].Value.ToString();
                dataGridView1.ClearSelection();
                dataGridView1.Rows[20].Cells[1].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, 20];
                MessageBox.Show(a);*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text);
            dataGridView1.Sort(dataGridView1.Columns[0],System.ComponentModel.ListSortDirection.Ascending);
        }

        private void mediaplayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch (e.newState)
            { 
                case 1: //Stopped
                    timer1.Enabled = false;
                    mediaplayer.close();
                    HardsubBtn.Enabled = true;
                    break;

                case 3:
                    label2.Text = "";
                    timer1.Enabled = true;
                    HardsubBtn.Enabled = false;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            path = txtAviFile.Text.Substring(0, txtAviFile.Text.Length - 3);
            path = path + "lrc";
            StreamWriter wr = new StreamWriter(path);
            for (i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                wr.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + dataGridView1.Rows[i].Cells[1].Value.ToString());
            }
            wr.Flush();
            wr.Close();
        }

        private void HardsubBtn_Click(object sender, EventArgs e)
        {
            
            ExtractSound();
            Hardsub();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form a=new AboutBox1();
            a.Show();

            //MessageBox.Show("Kevin Darmawan L.\t26409022\nAndreanus Agung\t26409023\nPaul Agustinus\t26409034\nFujianto\t\t26409038\nNikolas Wijaya K.\t26409045","Kelompok 18");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AviManager a = new AviManager(txtAviFile.Text, true);
            VideoStream b = a.GetVideoStream();
            b.GetFrameOpen();
            Bitmap c = b.GetBitmap(100);
            StringFormat strfrmt=new StringFormat();
            strfrmt.Alignment=StringAlignment.Center;
            Graphics ga = Graphics.FromImage(c);
            ga.DrawString("hahaha", new Font("Tahoma", 20), Brushes.Red, new PointF(400,0),strfrmt);
            //c=new Bitmap(640,360,ga);
            string path = txtAviFile.Text.Substring(0, txtAviFile.Text.Length - 3);
            path=path+"bmp";
            c.Save(path);
            b.GetFrameClose();
            b.Close();
            a.Close();
            /*double c = (double)b.CountFrames / b.FrameRate;
            c=Math.Round(c, 0);
            MessageBox.Show(c.ToString());*/
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string asa = "05"; int ada;
            AviManager a = new AviManager(txtAviFile.Text, true);
            VideoStream b = a.GetVideoStream();
            ada = Convert.ToInt32(asa) + (int)b.FrameRate;
            asa = ada.ToString();
            MessageBox.Show(asa.Substring(1,1));
            
        }

    }
}
