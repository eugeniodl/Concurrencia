﻿


var t = Task.Factory.StartNew(() => MetodoTask());

// utilizando factory task
TaskFactory tf = new TaskFactory();
Task t1 = tf.StartNew(MetodoTask);

// utilizando un factor task via task
Task t2 = Task.Factory.StartNew(MetodoTask);

// utilizando un constructor Task
Task t3 = new Task(MetodoTask);
t3.Start();

Task t4 = Task.Run(() => MetodoTask());

Console.ReadKey();

void MetodoTask()
{
    Console.WriteLine("Ejecutando una tarea => MetodoTask()");
    Console.WriteLine("Task id: {0}", Task.CurrentId);
}