using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> schedule = Console.ReadLine().Split(", ").ToList();

            string userInput = string.Empty;


            while ((userInput = Console.ReadLine()) != "course start")
            {
                List<string> commandWithParams = userInput.Split(':').ToList();

                string command = commandWithParams[0];

                switch (command)
                {
                    case "Add":

                        //Add: { lessonTitle} – add the lesson to the end of the schedule, if it does not exist.

                        string lessonTitleToAdd = commandWithParams[1];

                        if(!schedule.Contains(lessonTitleToAdd))
                        {
                            schedule.Add(lessonTitleToAdd);
                        }

                        break;

                    case "Insert":

                        //Insert:{ lessonTitle}:{ index} – insert the lesson to the given index, if it does not exist.

                        string lessonTitleToInsert = commandWithParams[1];
                        int index = int.Parse(commandWithParams[2]);

                        if (!schedule.Contains(lessonTitleToInsert))
                        {
                            schedule.Insert(index, lessonTitleToInsert);
                        }

                        break;

                    case "Remove":

                        //Remove:{ lessonTitle} – remove the lesson, if it exists.

                        string lessonTitleToRemove = commandWithParams[1];

                        schedule.Remove(lessonTitleToRemove);
                        schedule.Remove(lessonTitleToRemove + "-Exercise");

                        break;

                    case "Swap":

                        //Swap:{ lessonTitle}:{ lessonTitle} – change the place of the two lessons, if they exist.

                        string firstLessonToSwap = commandWithParams[1];
                        string secondLessonToSwap = commandWithParams[2];

                        if (schedule.Contains(firstLessonToSwap) && schedule.Contains(secondLessonToSwap))
                        {
                            int firstIndex = schedule.IndexOf(firstLessonToSwap);
                            int firstExerciseIndex = schedule.IndexOf(firstLessonToSwap + "-Exercise");
                            int secondIndex = schedule.IndexOf(secondLessonToSwap);
                            int secondExerciseIndex = schedule.IndexOf(secondLessonToSwap + "-Exercise");


                            string tempStr = schedule[firstIndex];
                            schedule[firstIndex] = schedule[secondIndex];
                            schedule[secondIndex] = tempStr;

                            if (firstExerciseIndex != -1)
                            {
                                if (secondIndex + 1 < schedule.Count)
                                {
                                    schedule.Insert(secondIndex + 1, schedule[firstExerciseIndex]);
                                }
                                else
                                {
                                    schedule.Add(schedule[firstExerciseIndex]);
                                }

                                schedule.RemoveAt(firstExerciseIndex + 1);
                            }

                            if (secondExerciseIndex != -1)
                            {
                                if (firstIndex + 1 < schedule.Count)
                                {
                                    schedule.Insert(firstIndex + 1, schedule[secondExerciseIndex]);
                                }
                                else
                                {
                                    schedule.Add(schedule[secondExerciseIndex]);
                                }

                                schedule.RemoveAt(secondExerciseIndex + 1);
                            }

                        }
                        break;

                    case "Exercise":

                        //Exercise:{ lessonTitle} – add Exercise in the schedule right after the lesson index
                        //if the lesson exists and there is no exercise already, in the following format "{lessonTitle}-Exercise".
                        //If the lesson doesn`t exist, add the lesson in the end of the course schedule, followed by the Exercise.
                        //Each time you Swap or Remove a lesson, you should do the same with the Exercises, if there are any, which follow the lessons.

                        string lessonTitle = commandWithParams[1];
                        string exerciseTitle = lessonTitle + "-Exercise";

                        if (schedule.Contains(lessonTitle) && !schedule.Contains(exerciseTitle))
                        {
                            schedule.Insert(schedule.IndexOf(lessonTitle) + 1, exerciseTitle);
                        }
                        else if(!schedule.Contains(lessonTitle))
                        {
                            schedule.Add(lessonTitle);
                            schedule.Add(exerciseTitle);
                        }

                        break;
                }
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }

        }
    }
}
