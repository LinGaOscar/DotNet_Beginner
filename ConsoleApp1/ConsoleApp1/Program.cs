// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int i = 0;
short sh = 0;
long lo = 0;
Console.WriteLine("i = " + i);
Console.WriteLine("i = {0}, {1}", i, "string");
// ctrl + k + d 快速對齊
double d = 0;
double dl = 0d;
float f = 0;
float fl = 0f;
decimal dm1 = 0;
decimal dm2 = 0m;
bool b = false;

char c1 = 'A'; // ' 2byte

string s1 = "this is a string";
const string s2 = "this is a string";

var d5 = 0d;
var f5 = 0f;
var dm5 = 5m;
var cc = 'b';
var s3 = "string";

//operators

var r1 = (d + f) * 2 / 4;
var r2 = 14 / 3;
var r6 = s1 + s2;
Console.WriteLine($"s1 + s2 = {r6}");