var
  product, number, i, n: integer;
  f: file of integer;

begin
  assign (f,'file.txt');
  rewrite (f);
  writeln ('Количество компонент?');
  readln (n);
  writeln ('Ввести компоненты');
  for i:=1 to 8 do
    begin
      readln (number);
      write (f, number);
    end;
  close (f);
  reset (f);
  writeln ('Компоненты файла:');
  for i:=1 to 8 do
    begin
      read (f, number);
      write (' ',number);
    end;
  close (f);
  reset (f);
  product:=1;
  for i:=1 to 8 do
    begin
      read (f, number);
      product:= product*number;
    end;
  close (f);
  writeln;
  writeln ('Произведение компонент: ', product);
  readln;
end.
