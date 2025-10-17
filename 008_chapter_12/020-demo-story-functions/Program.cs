void A() { };
void B(int x) { };
int C() { return 0; };
int D(int x) { return x + 1; };

A();
B(1);
int res = C();
C();
int value = 12;
res = D(value);
D(22);

Console.WriteLine(res);