//Tyler Simpson
//Lecture 4 Classes
//2-8-2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lecture5_Notes_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        public MainWindow()
        {
            
            InitializeComponent();

            //Make new instance by referencing object in class, like movie. Keyword new to create new object in memory
            Movie waynesWorld = new Movie();

            //access members of an object by using . aka dot
            waynesWorld.MovieName = "Wayne's World";
            waynesWorld.Rating = 5;
            waynesWorld.Director = "Penelope Spheeris";
            waynesWorld.Year = 1992;

            Movie waynesWorld2 = new Movie();

            waynesWorld2.MovieName = "Wayne's World 2";
            waynesWorld2.Rating = 5;
            waynesWorld2.Director = "Stephen Surjik";
            waynesWorld2.Year = 1993;

            
            //creating new instance of student object using constructor
            Student student1 = new Student("Tyler", "Simpson", 100, 100);
            Student student2 = new Student("Shiva", "Fluffy");

            students.Add(student1);
            students.Add(student2);

            Venue venue1 = new Venue("Motor", 2500.00m, 300, "98056");
            Venue venue2 = new Venue("Citadel", 1300.00m, 200, "98178");

            FormattedVenue(venue1);
           
        }
        public void FormattedVenue(Venue venue)
        {
            MessageBox.Show(venue.Name + " " + venue.Price + " " + venue.Capacity + " " + venue.ZipCode);
        }
    }
}
