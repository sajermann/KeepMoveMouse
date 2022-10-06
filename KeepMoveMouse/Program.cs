// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Iniciando o KeepMoveMouse, by Sajermann");
[DllImport("user32.dll")]
static extern bool SetCursorPos(int X, int Y);

while (true)
{
  SetCursorPos(0, 0);
  await Task.Delay(100);
  SetCursorPos(500, 500);
  await Task.Delay(2000);
}