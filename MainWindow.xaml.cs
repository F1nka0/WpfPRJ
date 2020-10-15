using BorisPRJ.DataTypes;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Xml;
using System.Linq;
namespace BorisPRJ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            firstFloorsRadio.IsChecked = true;
        }
        
        public void Create() 
        {
            File.Copy(@"Otchyot_Shablon_K_dezhurnogo.xml", @"C:\Users\xbox0\OneDrive\Рабочий стол\test.txt");
            StreamReader Container = new StreamReader(File.Open(@"C:\Users\xbox0\OneDrive\Рабочий стол\test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite));
            string read = Container.ReadToEnd();
            Container.Close();
            read = read.Replace("datedatedate", System.DateTime.Now.ToString());//а вот тут я 15 минут не могу понять, что этот расширяющий метод возвращает изменённут строку , а не меняет её 

            /*
             тута
             */
            read = read.Replace("object1Time", object1Time.Text);
            read = read.Replace("object2Time", object2Time.Text);
            read = read.Replace("object3Time", object3Time.Text);
            read = read.Replace("object1", object1.Text);
            read = read.Replace("object2", object2.Text);
            read = read.Replace("object3", object3.Text);
            read = read.Replace("firstFloorLabel", firstFloorLabel.Content.ToString());
            read = read.Replace("secondFloorLabel", secondFloorLabel.Content.ToString());
            read = read.Replace("firstFloorLabel", firstFloorLabel.Content.ToString());
            read = read.Replace("secondFloorLabel", secondFloorLabel.Content.ToString());
            read = read.Replace("firstFloorLabel", firstFloorLabel.Content.ToString());
            read = read.Replace("secondFloorLabel", secondFloorLabel.Content.ToString());
            read = read.Replace("toilets1Checked", (bool)toilets1Checked.IsChecked ? "Да" : "Нет");
            read = read.Replace("toilets2Checked", (bool)toilets2Checked.IsChecked ? "Да" : "Нет");
            read = read.Replace("coridors1Checked", (bool)coridors1Checked.IsChecked ? "Да" : "Нет");
            read = read.Replace("coridors2Checked", (bool)coridors2Checked.IsChecked ? "Да" : "Нет");
            read = read.Replace("rooms1Checked", (bool)rooms1Checked.IsChecked ? "Да" : "Нет");
            read = read.Replace("rooms2Checked", (bool)rooms2Checked.IsChecked ? "Да" : "Нет");
            read = read.Replace("boredStudentInitials1", boredStudentInitials1.Text);
            read = read.Replace("boredStudentInitials2", boredStudentInitials2.Text);
            read = read.Replace("boredStudentInitials3", boredStudentInitials3.Text);
            read = read.Replace("boredStudentInitials4", boredStudentInitials4.Text);
            read = read.Replace("boredStudentGroup1", boredStudentGroup1.Text);
            read = read.Replace("boredStudentGroup2", boredStudentGroup2.Text);
            read = read.Replace("boredStudentGroup3", boredStudentGroup3.Text);
            read = read.Replace("boredStudentGroup4", boredStudentGroup4.Text);
            read = read.Replace("boredStudentTemperature1", boredStudentTemperature1.Text);
            read = read.Replace("boredStudentTemperature2", boredStudentTemperature2.Text);
            read = read.Replace("boredStudentTemperature3", boredStudentTemperature3.Text);
            read = read.Replace("boredStudentTemperature4", boredStudentTemperature4.Text);
            read = read.Replace("dutyComboBox", dutyComboBox.Text);
            read = read.Replace("boredStudentReason1", boredStudentReason1.Text);
            read = read.Replace("boredStudentReason2", boredStudentReason2.Text);
            read = read.Replace("boredStudentReason3", boredStudentReason3.Text);
            read = read.Replace("boredStudentReason4", boredStudentReason4.Text);
            read = read.Replace("commentsBox", commentsBox.Text);
            read = read.Replace("missed1Group", missed1Group.Text);
            read = read.Replace("missed2Group", missed2Group.Text);
            read = read.Replace("missed3Group", missed3Group.Text);
            read = read.Replace("missed3Group", missed3Group.Text);
            read = read.Replace("missed1List", missed1List.Text);
            read = read.Replace("missed2List", missed2List.Text);
            read = read.Replace("missed3List", missed3List.Text);
            read = read.Replace("missed1Fact", missed1Fact.Text);
            read = read.Replace("missed2Fact", missed2Fact.Text);
            read = read.Replace("missed3Fact", missed3Fact.Text);
            read = read.Replace("missed1Missed", missed1Missed.Text);
            read = read.Replace("missed2Missed", missed2Missed.Text);
            read = read.Replace("missed3Missed", missed3Missed.Text);
            read = read.Replace("faultStudentName1", faultStudentName1.Text);
            read = read.Replace("faultStudentName2", faultStudentName2.Text);
            read = read.Replace("faultStudentName3", faultStudentName3.Text);
            read = read.Replace("faultStudentName4", faultStudentName4.Text);
            read = read.Replace("faultStudentName5", faultStudentName5.Text);
            read = read.Replace("faultStudentGroup1", faultStudentGroup1.Text);
            read = read.Replace("faultStudentGroup2", faultStudentGroup2.Text);
            read = read.Replace("faultStudentGroup3", faultStudentGroup3.Text);
            read = read.Replace("faultStudentGroup4", faultStudentGroup4.Text);
            read = read.Replace("faultStudentGroup5", faultStudentGroup5.Text);
            read = read.Replace("faultStudentTemperature1", faultStudentTemperature1.Text);
            read = read.Replace("faultStudentTemperature2", faultStudentTemperature2.Text);
            read = read.Replace("faultStudentTemperature3", faultStudentTemperature3.Text);
            read = read.Replace("faultStudentTemperature4", faultStudentTemperature4.Text);
            read = read.Replace("faultStudentTemperature5", faultStudentTemperature5.Text);
            read = read.Replace("faultStudentReason1", faultStudentReason1.Text);
            read = read.Replace("faultStudentReason2", faultStudentReason2.Text);
            read = read.Replace("faultStudentReason3", faultStudentReason3.Text);
            read = read.Replace("faultStudentReason4", faultStudentReason4.Text);
            read = read.Replace("faultStudentReason5", faultStudentReason5.Text);

            StreamWriter streamWriter = new StreamWriter(File.Open(@"C:\Users\xbox0\OneDrive\Рабочий стол\test.txt",FileMode.Create));
            streamWriter.Write(read);
            streamWriter.Close();
            try
            {
                File.Move(@"C:\Users\xbox0\OneDrive\Рабочий стол\test.txt", @"C:\Users\xbox0\OneDrive\Рабочий стол\test" +new System.Random().Next(0, 1000000)+ ".xml");
            }
            catch (System.Exception) {
                System.Threading.Thread.Sleep(2000);
                File.Move(@"C:\Users\xbox0\OneDrive\Рабочий стол\test.txt", @"C:\Users\xbox0\OneDrive\Рабочий стол\"+ new System.Random().Next(0,100000)+ "test.xml");

            }
            
        }
        private void createReport(object sender, RoutedEventArgs e)
        {
            //missed1List.Text = missed1List.Text.Equals("")?"0":missed1List.Text;
            //missed1Fact.Text = missed1Fact.Text.Equals("")?"0":missed1Fact.Text;
            //missed1Missed.Text = missed1Missed.Text.Equals("")?"0":missed1Missed.Text;
            //missed2List.Text = missed2List.Text.Equals("")?"0":missed2List.Text;
            //missed2Fact.Text = missed2Fact.Text.Equals("")?"0":missed2Fact.Text;
            //missed2Missed.Text = missed2Missed.Text.Equals("")?"0":missed2Missed.Text;
            //missed3List.Text = missed3List.Text.Equals("")?"0":missed3List.Text;
            //missed3Fact.Text = missed3Fact.Text.Equals("")?"0":missed3Fact.Text;
            //missed3Missed.Text = missed3Missed.Text.Equals("")?"0": missed3Missed.Text;

            //students = new List<Student>();
            //students.Add(new Student(boredStudentInitials1.Text, boredStudentGroup1.Text ,boredStudentTemperature1.Text, boredStudentReason1.Text, true));
            //students.Add(new Student(boredStudentInitials2.Text, boredStudentGroup2.Text, boredStudentTemperature2.Text, boredStudentReason2.Text, true));
            //students.Add(new Student(boredStudentInitials3.Text, boredStudentGroup3.Text, boredStudentTemperature3.Text, boredStudentReason3.Text, true));
            //students.Add(new Student(boredStudentInitials4.Text, boredStudentGroup4.Text, boredStudentTemperature4.Text, boredStudentReason4.Text, true));
            //students.Add(new Student(boredStudentInitials5.Text, boredStudentGroup5.Text, boredStudentTemperature5.Text, boredStudentReason5.Text, true));

            //students.Add(new Student(faultStudentName1.Text, faultStudentGroup1.Text, faultStudentTemperature1.Text, faultStudentReason1.Text, false));
            //students.Add(new Student(faultStudentName2.Text, faultStudentGroup2.Text, faultStudentTemperature2.Text, faultStudentReason2.Text, false));
            //students.Add(new Student(faultStudentName3.Text, faultStudentGroup3.Text, faultStudentTemperature3.Text, faultStudentReason3.Text, false));
            //students.Add(new Student(faultStudentName4.Text, faultStudentGroup4.Text, faultStudentTemperature4.Text, faultStudentReason4.Text, false));
            //students.Add(new Student(faultStudentName5.Text, faultStudentGroup5.Text, faultStudentTemperature5.Text, faultStudentReason5.Text, false));

            //floors = new List<Floor>();
            //floors.Add(new Floor((bool)toilets1Checked.IsChecked, (bool)rooms1Checked.IsChecked, (bool)coridors1Checked.IsChecked));
            //floors.Add(new Floor((bool)toilets2Checked.IsChecked, (bool)rooms2Checked.IsChecked, (bool)coridors2Checked.IsChecked));

            //groups = new List<Group>();
            //groups.Add(new Group(missed1Group.Text, int.Parse(missed1List.Text), int.Parse(missed1Fact.Text), int.Parse(missed1Missed.Text)));
            //groups.Add(new Group(missed2Group.Text, int.Parse(missed2List.Text), int.Parse(missed2Fact.Text), int.Parse(missed2Missed.Text)));
            //groups.Add(new Group(missed3Group.Text, int.Parse(missed3List.Text), int.Parse(missed3Fact.Text), int.Parse(missed3Missed.Text)));

            //objects = new List<Object>();
            //objects.Add(new Object(object1Time.Text, object1Time.Text));
            //objects.Add(new Object(object2Time.Text, object2Time.Text));
            //objects.Add(new Object(object3Time.Text, object3Time.Text));

            Create();
        }

        private void ChangeFloorsToFirst(object sender, RoutedEventArgs e)
        {
            firstFloorLabel.Content = "1 этаж";
            secondFloorLabel.Content = "3 этаж";
        }

        private void ChangeFloorsToSecond(object sender, RoutedEventArgs e)
        {
            
            firstFloorLabel.Content = "2 этаж";
            secondFloorLabel.Content = "4 этаж";
        }
    }
}