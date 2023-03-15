const n=10;
var a:array[1..n] of byte;
     i:byte;
     p:integer;
begin
randomize;
p:=1;
for i:=1 to 10 do
 begin
  a[i]:=1+random(10);
  write(a[i]:3);
  if odd(i) then p:=a[i] + 1;
 end;
writeln;
write('P=',p);
readln;
end.
