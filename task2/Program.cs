﻿// Написать программу масштабирования фигуры. (0,0) (2,0) (2,2) (0,2)

double x1 = 0, y1 = 0,
    x2 = 2, y2 = 0,
    x3 = 2, y3 = 2,
    x4 = 0, y4 = 2;

Console.Write($"Задана фигура с координатами вершин ({x1}, {y1}), ({x2}, {y2}), ({x3}, {y3}), ({x4}, {y4})");
Console.WriteLine();

double k = 2;

x2 = (x2 - x1) * k + x1;
y2 = (y2 - y1) * k + y1;
x3 = (x3 - x1) * k + x1;
y3 = (y3 - y1) * k + y1;
x4 = (x4 - x1) * k + x1;
y4 = (y4 - y1) * k + y1;

Console.Write($"Фигура смасшабирована с коэффициентом {k}. Получившиеся координаты вершин ({x1}, {y1}), ({x2}, {y2}), ({x3}, {y3}), ({x4}, {y4})");