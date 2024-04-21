using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace WpfAssign
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();          

            //Initialize Shifts
            Shift shift = new Shift("Carlo",0,400);            
            shift = new Shift("Patrick", 120, 480);
            shift = new Shift("Morad", 120, 480);
            shift = new Shift("Ayub", 240, 720);


            //Initialize Appointments
            Appointment appointment = new Appointment("Dodge", 60, 120);
            appointment = new Appointment("BMW", 0, 60);
            appointment = new Appointment("Lexus", 0, 60);
            appointment = new Appointment("Ford", 0, 60);
        }                


        private void Button_Assign_Ayoub_Click(object sender, RoutedEventArgs e)
        {
            Task.Assign_Patrick();
            Refresh_UI();
        }

        private void Button_Assign_Patrick_Click(object sender, RoutedEventArgs e)
        {
            Task.Assign_Patrick();
            Refresh_UI();
        }

        private void Refresh_UI()
        {
            TextBlock T;
            Canvas C;

            CanvasLeft.Children.Clear();
            CanvasMain.Children.Clear();            

            List<Task> tasks = Task.Assign_Patrick();
            //List<Task> tasks = Task.Assign_Ayoub();


            //Draw SHifts
            int row = 0;
            foreach ( Shift s in  Shift.shifts ) 
            {
                C = new Canvas();
                C.Width = s.Width;
                C.Height = 39;
                C.Background = Brushes.Gray;
                CanvasMain.Children.Add(C);
                Canvas.SetLeft(C, s.Start);
                Canvas.SetTop(C, row * 40 + 50); 




                T = new TextBlock();
                T.Text = s.Name;
                Canvas.SetTop(T, row * 40 + 50);
                CanvasLeft.Children.Add(T);

                //Draw Tasks
                foreach (Task t in tasks)
                {
                    if(t.shift == s)
                    {
                        C = new Canvas();
                        C.Width = t.Width;
                        C.Height = 38;
                        C.Background = Brushes.LightBlue;
                        CanvasMain.Children.Add(C);
                        Canvas.SetLeft(C, t.Start);
                        Canvas.SetTop(C, row * 40 + 50);

                        T = new TextBlock();
                        T.Text = t.appointment.id;
                        C.Children.Add(T);
                    }                    
                }

                row++;
            }


            //Draw Availability
            T = new TextBlock();
            T.Text = "Availability";
            Canvas.SetTop(T, row * 40 + 50);
            CanvasLeft.Children.Add(T);
            foreach (Range r in Task.Availabilites(tasks))
            {
                C = new Canvas();
                C.Width = r.Width;
                C.Height = 20;
                C.Background = Brushes.Green;
                CanvasMain.Children.Add(C);
                Canvas.SetLeft(C, r.Start);
                Canvas.SetTop(C, row * 40 + 50);
            }
        }
    }
}