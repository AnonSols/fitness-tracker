using System;
using System.Collections.Generic;
using System.Linq;
using FitnessTrackerGUI.Models;

namespace FitnessTrackerGUI.Services
{
    public class WorkoutService
    {
        private readonly List<Workout> _workouts = new();
        private readonly List<Activity> _activities = new();
        private int _calorieGoal;

        public void AddWorkout(string name, int duration)
        {
            var workout = new Workout(name, duration);
            _workouts.Add(workout);
            // Console.WriteLine("Workout has been added successfully!! \n");
        }

        public void WorkoutList()
        {
            if (_workouts.Count == 0)
            {
                // Console.WriteLine("No workouts found. \n");
                return;
            }

            // Console.WriteLine("Your workouts: \n");
            foreach (var workout in _workouts)
            {
                // Console.WriteLine($"{workout.Date.ToShortDateString()} - {workout.WorkoutName} for {workout.DurationInMinutes} minutes");
            }
            // Console.WriteLine("\n");
        }

        // Logs out our activities
        public void LogActivity(Activity activity)
        {
            _activities.Add(activity);
            // Console.WriteLine($"Logged {activity.Name} ({activity.CalculateCaloriesBurned()} kcal)");
        }

        // All logged workouts
        public void ListWorkouts()
        {
            if (_activities.Count == 0)
            {
                // Console.WriteLine("No workouts Logged yet.");
                return;
            }

            foreach (var activity in _activities)
            {
                // Console.WriteLine($"{activity.Date:g} - {activity.Name} - {activity.CalculateCaloriesBurned()} kcal burned");
            }
        }

        // sets my user's calories goal
        public void SetCalorieGoal(int goal) => _calorieGoal = goal;

        // calculates the total calories burned
        public double GetTotalCaloriesBurned() => _activities.Sum(a => a.CalculateCaloriesBurned());
    }
}