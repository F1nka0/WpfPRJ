using BorisPRJ.DataTypes;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

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

        private void createReport(object sender, RoutedEventArgs e)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(boredStudentInitials1.Text, boredStudentGroup1.Text ,boredStudentTemperature1.Text, boredStudentReason1.Text, true));
            students.Add(new Student(boredStudentInitials2.Text, boredStudentGroup2.Text, boredStudentTemperature2.Text, boredStudentReason2.Text, true));
            students.Add(new Student(boredStudentInitials3.Text, boredStudentGroup3.Text, boredStudentTemperature3.Text, boredStudentReason3.Text, true));
            students.Add(new Student(boredStudentInitials4.Text, boredStudentGroup4.Text, boredStudentTemperature4.Text, boredStudentReason4.Text, true));
            students.Add(new Student(boredStudentInitials5.Text, boredStudentGroup5.Text, boredStudentTemperature5.Text, boredStudentReason5.Text, true));

            students.Add(new Student(faultStudentName1.Text, faultStudentGroup1.Text, faultStudentTemperature1.Text, faultStudentReason1.Text, false));
            students.Add(new Student(faultStudentName2.Text, faultStudentGroup2.Text, faultStudentTemperature2.Text, faultStudentReason2.Text, false));
            students.Add(new Student(faultStudentName3.Text, faultStudentGroup3.Text, faultStudentTemperature3.Text, faultStudentReason3.Text, false));
            students.Add(new Student(faultStudentName4.Text, faultStudentGroup4.Text, faultStudentTemperature4.Text, faultStudentReason4.Text, false));
            students.Add(new Student(faultStudentName5.Text, faultStudentGroup5.Text, faultStudentTemperature5.Text, faultStudentReason5.Text, false));

            List<Floor> floors = new List<Floor>();
            floors.Add(new Floor((bool)toilets1Checked.IsChecked, (bool)rooms1Checked.IsChecked, (bool)coridors1Checked.IsChecked));
            floors.Add(new Floor((bool)toilets2Checked.IsChecked, (bool)rooms2Checked.IsChecked, (bool)coridors2Checked.IsChecked));

            List<Group> groups = new List<Group>();
            groups.Add(new Group(missed1Group.Text, int.Parse(missed1List.Text), int.Parse(missed1Fact.Text)));
            groups.Add(new Group(missed2Group.Text, int.Parse(missed2List.Text), int.Parse(missed2Fact.Text)));
            groups.Add(new Group(missed3Group.Text, int.Parse(missed3List.Text), int.Parse(missed3Fact.Text)));

            List <Object> objects = new List<Object>();
            objects.Add(new Object(object1Time.Text, object1Time.Text));
            objects.Add(new Object(object2Time.Text, object2Time.Text));
            objects.Add(new Object(object3Time.Text, object3Time.Text));

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