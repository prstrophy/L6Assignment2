using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace PolarHrm_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        //Initializing Graph
       
        //Declaring Array for storing different line data into it
        private string[] LinesOfFile;

        //Creating list and object for different class
        List<header> heading = new List<header>();
        public List<hrdata> hr = new List<hrdata>();
        List<parameters> parameters = new List<parameters>();
        parameters differentParameters = new parameters();
        
        gettersandsetters getandset = new gettersandsetters();      

        //Declaring a variable
        int linenum;

        //creating datatables 

        DataTable dt = new DataTable();    

        private void Form1_Load(object sender, EventArgs e)
        {
            readFiles();
             zgc = zedGraphStatic;
            GPane = zgc.GraphPane;
            zgc.IsZoomOnMouseCenter = true;
            zgc.IsEnableHZoom = true;
            zgc.IsEnableVZoom = false;
            showGraph();
        }
        

        public void readFiles()
        {
            //Getting filename from the initiator form
            string filename = Main.fname();

            //Reading the File
            textpathh.Text = Path.GetFileNameWithoutExtension(filename);
            txtpath2.Text = Path.GetExtension(filename);
            txtpathh.Text = filename;
            LinesOfFile = File.ReadAllLines(filename);
                    
                    //Executing the loop only when the file is not empty.
                    for (int i = 0; i < LinesOfFile.Length; i++)
                    {
                        if (LinesOfFile[i].Length > 0)
                        {
                            //Finding The Header and assigning it to Header Class, Here header is between []
                            if (LinesOfFile[i][0] == '[' && LinesOfFile[i][LinesOfFile[i].Length - 1] == ']')
                            {
                                //Assigning Headername to header list
                                heading.Add(new header { headername = LinesOfFile[i].Substring(1, LinesOfFile[i].Length - 2), headerline = i });

                            }
                        }
                    }


                
                //calling method to store particular set of data in objects

                dataParsing();

            
        }

        public void dataParsing()
        {
            //checking the filelist array with HRData header
            foreach (header a in heading)
            {
                linenum = a.headerline;

                //checking the condition
                switch (a.headername)
                {
                    case "Params":
                        {
                            int j = linenum + 1;
                            //seperating the values with tabs
                            string[] newline = LinesOfFile[j].Split('\t');
                            string value = newline[0];
                            int add = 0;
                            int b = 1;
                            string[] paramsValue = new string[22];
                            do
                            {
                                // for (int b = 0; b < value.Length; b++)
                                // {
                                //if (newline[b] == "=")
                                foreach (char ab in value)
                                {
                                    if (ab == '=')
                                    {
                                        paramsValue[add] = value.Substring(b, value.Length - b);
                                        // paramsValue[add] = "" + add;
                                    }

                                    b++;
                                }

                                //  }
                                b = 1;
                                add++;
                                j++;
                                newline = LinesOfFile[j].Split('\t');
                                value = newline[0];

                            } while (j < 24);//newline!=null);


                            //paramsData.Add(new Params
                            //inserting data in the params
                            differentParameters.Version = paramsValue[0];
                            differentParameters.Monitor = paramsValue[1];
                            differentParameters.SMode = paramsValue[2];
                            differentParameters.Date = paramsValue[3];
                            differentParameters.StartTime = paramsValue[4];
                            differentParameters.Length = paramsValue[5];
                            differentParameters.Interval = paramsValue[6];
                            differentParameters.Upper1 = paramsValue[7];
                            differentParameters.Lower1 = paramsValue[8];
                            differentParameters.Upper2 = paramsValue[9];
                            differentParameters.Lower2 = paramsValue[10];
                            differentParameters.Upper3 = paramsValue[11];
                            differentParameters.Lower3 = paramsValue[12];
                            differentParameters.Timer1 = paramsValue[13];
                            differentParameters.Timer2 = paramsValue[14];
                            differentParameters.Timer3 = paramsValue[15];
                            differentParameters.ActiveLimit = paramsValue[16];
                            differentParameters.MaxHR = paramsValue[17];
                            differentParameters.RestHR = paramsValue[18];
                            differentParameters.StartDelay = paramsValue[19];
                            differentParameters.VO2max = paramsValue[20];
                            differentParameters.Weight = paramsValue[21];


                            //adding the getter and setter
                            label1.Text = "Date::";
                            label2.Text = "Start Time::";
                            label3.Text = "Interval::";
                            label4.Text = differentParameters.Date;
                            label5.Text = differentParameters.StartTime;
                            label6.Text = differentParameters.Interval;

                            break;
                        }
                    case "HRData":
                        {


                            //using the loop to till the end of array to get values 
                            for (int j = linenum + 1; j < LinesOfFile.Length; j++)
                            {
                                //Spliting chars with tabs
                                string[] newline = LinesOfFile[j].Split('\t');


                                //Switching different versions 
                                switch (differentParameters.Version)
                                {

                                    case "105":
                                        {
                                            hr.Add(new hrdata
                                            {
                                                HeartRate = int.Parse(newline[0]),
                                                Speed = int.Parse(newline[1]),
                                                Cadence = int.Parse(newline[2])
                                            });

                                            break;
                                        }
                                    case "106":
                                        {


                                            //adding the values 
                                            hr.Add(new hrdata
                                            {
                                                HeartRate = int.Parse(newline[0]),
                                                Speed = int.Parse(newline[1]),
                                                Cadence = int.Parse(newline[2]),
                                                Altitude = int.Parse(newline[3]),
                                                Power = int.Parse(newline[4]),
                                                PowerBalancePedalling = int.Parse(newline[5])
                                            });

                                            break;
                                        }
                                    case "107":
                                        {
                                            //adding the values to the parameters
                                            hr.Add(new hrdata
                                            {
                                                HeartRate = int.Parse(newline[0]),
                                                Speed = int.Parse(newline[1]),
                                                Cadence = int.Parse(newline[2]),
                                                Altitude = int.Parse(newline[3]),
                                                Power = int.Parse(newline[4]),
                                                PowerBalancePedalling = int.Parse(newline[5]),
                                                AirPressure = int.Parse(newline[6])
                                            });
                                            break;
                                        }
                                }
                            }
                            break;
                        }

                }
            }


            //putting column name is data grid view as per version of parmas
            string[] columnNames = { " HeartRate", " Speed", " Cadence", " Altitude", " Power", "PowerBalancePedalling" };


            foreach (string col in columnNames)
            {
                dt.Columns.Add(col);
            }


            foreach (hrdata hd in hr)
            {
                dt.Rows.Add(hd.HeartRate, hd.Speed, hd.Cadence, hd.Altitude, hd.Power, hd.PowerBalancePedalling);
            }

            //variables initiated for heart rate
            int minHeartRate = 1000;
            int maxHeartRate = 0, sum = 0;
            int count = 0;

            //variables for altitude ,power,speed

            int minAltitude = 1000;
            int maxAltitude = 0;
            int minPower = 1000;
            int maxPower = 0;
            int minSpeed = 1000;
            int maxSpeed = 0;
            int minCadence = 1000;
            int maxCadence = 0;
            int count1 = 0, sum1 = 0;
            double distance;
            int speed;
            //calculating the data to find maximum,minimum

            foreach (hrdata value in hr)
            {
                //for heart rate
                int hrValue = value.HeartRate;
                if (hrValue < minHeartRate)
                {
                    minHeartRate = hrValue;
                }
                else if (hrValue > maxHeartRate)
                {
                    maxHeartRate = hrValue;
                }
                sum += hrValue;
                count ++;
                //for altitude 
                int altValue = value.Altitude;
                if (altValue < minAltitude)
                {
                    minAltitude = altValue;
                }
                else if (altValue > maxAltitude)
                {
                    maxAltitude = altValue;
                }

                //for power
                int PowerValue = value.Power;
                if (PowerValue < minPower)
                {
                    minPower = PowerValue;
                }
                else if (altValue > maxPower)
                {
                    maxPower = PowerValue;
                }
                //speed

                int SpeedValue = value.Speed;
                if (SpeedValue < minSpeed)
                {
                    minSpeed = SpeedValue;
                }
                else if (SpeedValue > maxSpeed)
                {
                    maxSpeed = SpeedValue;
                }
                sum1 += SpeedValue;
                count1 ++;
                //cadence

                int CadenceValue = value.Cadence;
                if (CadenceValue < minCadence)
                {
                    minCadence = CadenceValue;
                }
                else if (SpeedValue > maxCadence)
                {
                    maxCadence = SpeedValue;
                }


            }
            //calculating the stats of heart rate
            label7.Text = "Average Heart Rate::" + (sum / count).ToString();
            label8.Text = "Maximum Heart Rate::" + maxHeartRate.ToString();
            label9.Text = "Minimum Heart Rate::" + minHeartRate.ToString();

            getandset.setMaxHeartRate(maxHeartRate);
            getandset.setMinHeartRate(minHeartRate);
            getandset.setMaxCadence(maxCadence);
            getandset.setMinCadence(minCadence);


            //calculating for altitude ,power ,speed
            label10.Text = "Maximun Power::" + maxPower.ToString() + "Watt";
            label11.Text = "Minimum Power::" + minPower.ToString() + "Watt";
            getandset.setMaxPower(maxPower);
            getandset.setMinPower(minPower);

            label12.Text = "Maximum Altitude::" + maxAltitude.ToString() + "Meter";
            label13.Text = "Minimum Altitude::" + minAltitude.ToString() + "Meter";
            getandset.setMaxAltitude(maxAltitude);
            getandset.setMinAltitude(minAltitude);

            label14.Text = "Maximum Speed::" + (maxSpeed/10).ToString()+"Km/Hr";
            label15.Text = "Minimum Speed::" + (minSpeed/10).ToString() + "Km/Hr";
            getandset.setMaxSpeed(maxSpeed);
            getandset.setMinSpeed(minSpeed);
            //total distance
            speed = sum1 / (count1 * 10);
            double interval = Double.Parse(differentParameters.Interval);
            double totalDataCount = count * interval;
            double totalTime = totalDataCount / 3600;
            distance = speed * totalTime;
            label21.Text = "Distance::" + distance.ToString() + "km";
          
            ParseData.DataSource = dt;
        }

        static DateTime start, duration;
        private void SetTime()
        {
            string startDate = differentParameters.Date;

            int year = Convert.ToInt32(startDate.Substring(0, 4));
            int month = Convert.ToInt32(startDate.Substring(4, 2));
            int day = Convert.ToInt32(startDate.Substring(6, 2));

            start = new DateTime(year, month, day, 0, 0, 0, 0);
            duration = start.AddSeconds(hr.Count);
        }
        GraphPane GPane;

        ZedGraphControl zgc;
  

        PointPairList heartratePPList = new PointPairList();
        PointPairList speedPPList = new PointPairList();
        PointPairList altitudePPList = new PointPairList();
        PointPairList caderancePPList = new PointPairList();
        PointPairList powerPPList = new PointPairList();

        LineItem hrCurve, spdCurve, altCurve, cadCurve, pwrCurve;

        double x, y1, y2, y3, y4, y5;

       

        private void showGraph()
        {

            GPane.Chart.Border.IsVisible = false;
            GPane.Title.Text = "Static Graph for the HRData";
            GPane.XAxis.Title.Text = "Time (minutes)";
            GPane.IsAlignGrids = true;

            //max and min values of lists are used as max and min scale in respective yaxis

            GPane.YAxis.Title.Text = "Heart Rate";
            GPane.YAxis.Color = Color.Red;
            GPane.YAxis.Scale.Max = getandset.getMaxHeartRate();
            GPane.YAxis.Scale.Min = getandset.getMinHeartRate();

            GPane.Y2Axis.IsVisible = true;
            GPane.Y2Axis.Title.Text = "Speed";
            GPane.Y2Axis.Color = Color.Green;
            GPane.Y2Axis.Scale.Max = getandset.getMaxSpeed(); ;
            GPane.Y2Axis.Scale.Min = getandset.getMinSpeed();

            var Y3Axis = GPane.AddYAxis("Cadence");
            GPane.YAxisList[Y3Axis].Color = Color.Blue;
            GPane.YAxisList[Y3Axis].Scale.Max = getandset.getMaxCadence();
            GPane.YAxisList[Y3Axis].Scale.Min = getandset.getMinCadence();


            var Y4Axis = GPane.AddYAxis("Altitude");
            GPane.YAxisList[Y4Axis].Color = Color.Gray;
            GPane.YAxisList[Y4Axis].Scale.Max = getandset.getMaxAltitude();
            GPane.YAxisList[Y4Axis].Scale.Min = getandset.getMinAltitude();


            var Y5Axis = GPane.AddYAxis("Power");
            GPane.YAxisList[Y5Axis].Color = Color.Magenta;
            GPane.YAxisList[Y5Axis].Scale.Max = getandset.getMaxSpeed();
            GPane.YAxisList[Y5Axis].Scale.Min = getandset.getMinSpeed();


            GPane.YAxis.Title.Text = "Heart Rate";

            GPane.XAxis.Type = AxisType.Date;
            GPane.XAxis.Scale.Format = "HH:mm:ss";
            GPane.XAxis.MinorGrid.IsVisible = true;
            GPane.XAxis.MajorGrid.IsVisible = true;

            SetTime();

            GPane.XAxis.Scale.Min = new XDate(start);
            GPane.XAxis.Scale.Max = new XDate(duration);
            GPane.XAxis.Scale.MinorUnit = DateUnit.Second;
            GPane.XAxis.Scale.MajorUnit = DateUnit.Minute;

            zgc.ScrollMinX = new XDate(start);
            zgc.ScrollMaxX = new XDate(duration);

            int i = 0;
            //    for (int i = 0; i < hrList.Count; i++//)
            foreach (hrdata hrd in hr)
            {
                x = (double)new XDate(start.AddSeconds(i));
                y1 = hrd.HeartRate;
                y2 = hrd.Cadence;
                y3 = hrd.Speed;
                y4 = hrd.Altitude;
                y5 = hrd.Power;

                //points added to point pair list
                heartratePPList.Add(x, y1);
                caderancePPList.Add(x, y2);
                speedPPList.Add(x, y3);
                altitudePPList.Add(x, y4);
                powerPPList.Add(x, y5);
                i++;
            }

            //adding curves to zgc
            hrCurve = GPane.AddCurve("HeartRate",
                 heartratePPList, Color.Red, SymbolType.None);

            cadCurve = GPane.AddCurve("Cadence",
                 caderancePPList, Color.Blue, SymbolType.None);
            cadCurve.YAxisIndex = Y3Axis;

            spdCurve = GPane.AddCurve("Speed",
                 speedPPList, Color.Green, SymbolType.None);
            spdCurve.IsY2Axis = true;

            altCurve = GPane.AddCurve("Altitude",
                 altitudePPList, Color.Gray, SymbolType.None);
            altCurve.YAxisIndex = Y4Axis;

            pwrCurve = GPane.AddCurve("Power",
                 powerPPList, Color.Magenta, SymbolType.None);
            pwrCurve.YAxisIndex = Y5Axis;

            //   SetSize();
            zgc.AxisChange();
            //refresh
            zgc.Invalidate();
        }

        private void ParseData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void ParseData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

    

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                double newDistance = distance * 0.62;

                double newMaxSpeed = (maxSpeed / 10) * 0.62;
                double newMinSpeed = (minSpeed / 10) * 0.62;
                maxSpeed.Text = newMaxSpeed.ToString() + "miles/hr";
                minSpeed.Text = newMinSpeed.ToString() + "miles/hr";
                label21.Text = newDistance.ToString() + "Miles";

            }
            else
            {

                maxSpeed.Text = (maxSpeed / 10).ToString() + "km/hr";
                minSpeed.Text = (minSpeed / 10).ToString() + "km/hr";
                label21.Text = distance.ToString() + "km";
            }

        
    }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkHr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHr.Checked)
            {
                hrCurve.IsVisible = true;
                zgc.Invalidate();
            }
            else
            {
                hrCurve.IsVisible = false;
                zgc.Invalidate();
            }
        }


        private void chkSpd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpd.Checked)
            {
                spdCurve.IsVisible = true;
                zgc.Invalidate();
            }
            else
            {
                spdCurve.IsVisible = false;
                zgc.Invalidate();
            }
        }

        private void chkCad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCad.Checked)
            {
                cadCurve.IsVisible = true;
                zgc.Invalidate();
            }
            else
            {
                cadCurve.IsVisible = false;
                zgc.Invalidate();
            }
        }

        private void chkAlt_CheckedChanged(object sender, EventArgs e)
        {

            if (chkAlt.Checked)
            {
                altCurve.IsVisible = true;
                zgc.Invalidate();
            }
            else
            {
                altCurve.IsVisible = false;
                zgc.Invalidate();
            }

        }

        private void chkPwr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPwr.Checked)
            {
                pwrCurve.IsVisible = true;
                zgc.Invalidate();
            }
            else
            {
                pwrCurve.IsVisible = false;
                zgc.Invalidate();
            }

        }

        private void buttonZReset_Click(object sender, EventArgs e)
        {
            zgc.ZoomOutAll(GPane);
            zgc.Invalidate();

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void zedGraphControl1_Load_1(object sender, EventArgs e)
        {

        }


    }

}
