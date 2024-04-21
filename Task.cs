using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace WpfAssign
{
    internal class Task : Range
    {        
        public Shift shift;
        public Appointment appointment;
        

        public Task(Shift S, Appointment a, Range range) :  base(range.Start, range.End)
        {                                
            this.appointment = a;         
            this.shift = S;
        }

        public Task(Shift S, Appointment a, int start, int end) : base(start, end)
        {
            this.appointment = a;
            this.shift = S;
        }

        public Task(Shift S, Appointment a) : base(a.Start, a.End)
        {
            this.appointment = a;
            this.shift = S;
        }

        static public List<Task> Assign_Ayoub()
        {
            //Reset All Tasks
            List<Task> tasks = new List<Task>();


            //Ayub ajoute ton code ici

            return tasks;
        }

        static public List<Task> Assign_Patrick()
        {
            //Reset All Tasks
            List<Task> tasks = new List<Task>();           

            //Just assign 1st appointment on first shift
            
            Task T1 = new Task(Shift.shifts[0], Appointment.appointments[0]);
            tasks.Add(T1);

            return tasks;
        }

        static public List<Range> Availabilites(List<Task> list)
        {
            List < Range > ranges = new List<Range>();

            foreach (Task t in list) 
            {
                //Ayub ajoute ton code ici

                Range r = new Range(0,720);

                ranges.Add(r);

            }

            return ranges;
        }
    }
}
