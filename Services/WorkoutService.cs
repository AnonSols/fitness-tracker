using System;
using System.Collections.Generic;
using FitnessTrackerApp.Models;

namespace FitnessTrackerApp.Services
{
    public class WorkoutService
    {
        private List<Workout> _workouts = new List<Workout>();
        public void AddWorkout(string name, int duration)
        {
            var workout = new Workout(name, duration);
            _workouts.Add(workout);
            Console.WriteLine("Workout has been added successfully!! \n");
        }

        public void WorkoutList()
        {
            if (_workouts.Count == 0)
            {
                Console.WriteLine("No workouts found. \n");
                return;
            }

            Console.WriteLine("Your workouts: \n");
            foreach (var workout in _workouts)
            {
                Console.WriteLine($"{workout.Date.ToShortDateString()} - {workout.WorkoutName} for {workout.DurationInMinutes} minutes");
            }
            Console.WriteLine("\n");
        }
    }
}