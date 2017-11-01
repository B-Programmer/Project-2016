(* A Pascal Program developed to implement Ant Colony Algorithm for Traveling Salesman Problem(TSP)
 * DEVELOPED BY: ADEJUMO TAOFEEK TUNDE
 * MATRIC NO: 14/CSH/0582
 *)
Program AntColony_TSP;
uses Crt;
Const
	MAX	= 10; 
	INFINITY 	= 9999;
    NULL = 0;
TYPE
        tbl2Dim = Array[1..MAX, 1..MAX] of Integer;
        strTbl = Array[1..MAX] of String;
        tbl1Dim = Array[1..MAX] of Integer;
Var
	City :strTbl;
	CityIndex    :tbl1Dim;
	NumberOfCities :Integer;
	Distance :tbl2Dim;
	bCost :Integer;
    ch : char;
    numberOfIterations :Integer;
    numberOfAnts :Integer;

Procedure initDistance(Var W :tbl2Dim; N :Integer);
Var 
	i, j :Integer;
Begin     
       For i := 1  to N do
       Begin
             For j := 1 to N do
             Begin
              W[i,j] := NULL; (* Set the initial distance for the 2 cities to zero*)
             End 
       End;
       bCost := INFINITY; {initialize the best Cost to Infinity}
End;

Procedure ReadNodes(Var Nodes :strTbl; Var nIndex :tbl1Dim; N :Integer);
Var
	i : Integer;
Begin            
       Writeln('Read in the names of all Nodes(Cities) in the graph G(V,E) for the TSP:');
       For i := 1  To N do
         Begin
             Writeln('Read in the names of Node(City): ', i);
             Readln(Nodes[i]); (*store name in the Nodes array*)
             nIndex[i] := i; (*store the name index in another array*)
         End            
End;

Procedure ReadDistance(Var W :tbl2Dim; N :Integer; nodes :strTbl);
Var 
	i, j :Integer;
Begin     
  initDistance(W, N);
  Writeln('Read in distance(Weight/Cost) between 2 Cities (u,v) in the graph G of TSP:');
  For i := 1  to N-1 do
   Begin
      Writeln;
     For j := I+1 to N do
      Begin
       Writeln('Read in distance(Weight/Cost) between City: ', I,' and City: ', J, ' for the TSP:', nodes[i],'-', nodes[j]);
       Readln(W[i,j]);
       if (W[i,j] <> NULL)Then
         W[j,i] := W[i,j]; (* Set the distance for the 2 cities in reverse order*)
      End 
   End       
End;
Procedure getBestRoutes(nIndex :tbl2Dim; N :Integer; mCost: Integer; K :Integer);
Var
	i : Integer;
Begin            
    If(bCost > mCost) Then
     Begin
       bCost := mCost; {Set new value for the best Cost}
       For i := 1  To N do
         Begin
             CityIndex[i] := nIndex[K,i];
         End
     End
End;

Procedure displayBestRoutes(nIndex :tbl1Dim; N :Integer; mCost: Integer; strDisplay :String);
Var
	i : Integer;
Begin            
       Writeln(strDisplay);
       Write('City: ');
       For i := 1  To N do
         Begin
             Write(City[nIndex[i]],'-');
         End;
         Writeln(City[1],' = ', mCost);
End;

Function getDistance(nIndex :tbl2Dim; v :Integer; k :Integer):Integer;
{Get the total distance represented by the ant movement in RIndex}
Var
   t, I :Integer;
Begin
     t:= 0;
     For I := 2 to v do
         t := t + Distance[nIndex[k, I-1], nIndex[k, I]];
     t := t + Distance[nIndex[k, v], 1];
     getBestRoutes(nIndex, v,  t, k); {Check if and get the best routes}
     getDistance := t;
End;
Procedure DisplayRoutes(nIndex : tbl2Dim; v :Integer; k :Integer; strDisplay :String);
Var
	i : Integer;
Begin            
       Writeln(strDisplay);
       Write('Ant ', k, ' City: ');
       For i := 1  To v do
         Begin
             Write(City[nIndex[k,i]],'-');
         End;
       Writeln(City[1],' = ', getDistance(nIndex, v, k));
End;
Procedure AntColony(nIterations :Integer; nAnts :Integer);
label 5, 10, 20, 30;
{Const
      Alpha = 1;
       Beta = 2; }
var
   h, Gthoinit, thoinit :Array[1..MAX, 1..MAX] of Real;
   I, J, N, C :Integer;
   P, CumP :Array[1..Max] of real;
   SumP, r, e : real;
   Count, K, V :Integer;
   RIndex : tbl2Dim;
   totalDistance : tbl1Dim;
Begin
   N := NumberOfCities; Count := 1;
   For I := 1 to N do
    Begin
         For J := 1 to N do
          Begin
               Gthoinit[I,J] := 1 {Initialize value of Global pheromones between cities}
          End
    End;
5:   K := 1; {Initialize no of ants}
     Writeln('Iteration', Count,': ');
10:
   For I := 1 to N do
    Begin
         For J := 1 to N do
          Begin
               h[I,J] := NULL;
               if(Distance[I,J] <> NULL) Then
               h[I,J] := 1.0/Distance[I,J] {Initialize value of visibility between cities}
          End
    End;
    For I := 1 to N do
    Begin
         For J := 1 to N do
          Begin
               thoinit[I,J] := Gthoinit[I,J] {Initialize value of Local pheromones between cities}
          End
    End;

    C := 1;   {Initialize the starting city as city 1}
    V := 1; RIndex[K, V] := C; {Set the starting city as city 1 for ant K}
20:
   For I := 1 to N do
       h[I,C] := NULL; {Initialize value of visibility of the current City, C to NULL}
   {Calculate the probabilities to visit other cities from the current city (C)}
    SumP := 0.0;
   For J := 1 to N do
    Begin
         {P[J] := exp(Alpha *ln(thoinit[C, J])) * exp(Beta *ln(h[C, J]));}
         P[J] := thoinit[C, J] * sqr(h[C, J]);
         SumP := SumP + P[J] {Initialize value of visibility of the current City, C to NULL}
    End;
   {Compute the probabilities of ant K going to another city from city C}
   For J := 1 to N do
        P[J] := P[J]/SumP;
   {Compute the Cummulative probabilities of ant K going to another city from city C}
   CumP[1] := P[1];
   For J := 2 to N do
       CumP[J] := CumP[J-1] + P[J];
   {* Generate a random number r for the choice of cities to be visited by comparing it with
    * the value of the cummulative probabilities}
   {randomize; }
   {r := (1.0 - 0.0) * random(1);}
   r := random;    {generate a pseudorandom number in the interval [0,1), .i.e. 0 <= result < 1}
   For J := 2 to N do
    Begin
     If( r < CumP[J]) Then
      Begin
           C:= J;  {Get the next city index}
           goto 30
      end
    End;
30:
   V := V + 1; RIndex[K,V] := C; {Store the next city to visited}
   If(V < N) then goto 20;
   DisplayRoutes(RIndex, V, K, 'The route starting from city 1 for the TSP:');
   totalDistance[K] := getDistance(RIndex, V, K); {Get the total distance represented by the ant movement in RIndex}
   K := K + 1; {Set the next ant K into operation}
   If(K <= nAnts)Then goto 10;
   {Using the total distance to update the global pheromones}
   e := 0.5; {initialize the evaporation coefficient}
   For I := 1 to N do
    Begin
      For J := 1 to N do
          Gthoinit[I,J] := (1 - e) * Gthoinit[I,J];
    end;
   For K := 1 to nAnts do
    Begin
       For V := 2 to N do
         Begin
          Gthoinit[RIndex[K,V-1],RIndex[K,V]] := Gthoinit[RIndex[K,V-1],RIndex[K,V]] + 1.0/totalDistance[K];
         End;
    End;
   Count := Count + 1; {Increase the number of Iteration}
   If(Count <= nIterations) Then goto 5; {Repeat operations for the next iteration}
End;

Begin
{Main program body starts here}
    randomize;
	Writeln('Welcome to Pascal Program developed to implement Ant Colony Algorithm for TSP:');
    Writeln('===============================================================================');
    Writeln('Read in Number(between 1 and 10) of Nodes(Cities) in Graph G(V,E) for the TSP: ');
    Readln(NumberOfCities);
    If ((NumberOfCities < 1) OR (NumberOfCities > MAX))Then
        Writeln('Wrong Input! Please, Read in correct digit from 1 to 10:')
    Else
		Begin
		   (*Construction of the  Graph G(V,E) for the TSP*)
		   ReadNodes(City, CityIndex, NumberOfCities); (* Read in N nodes*)
		   ReadDistance(Distance, NumberOfCities, City); (*Read in weight/cost of each edges*)
		   (*performing Brute Force Algorithm on the Graph for TSP*)
           {InitIndices(RIndex, SIndex, NumberOfCities);}
           Writeln('Ant Colony Optimization (ACO) Alogrithm Result: ');
           numberOfIterations := 50;
           numberOfAnts := 5;
		   AntColony(numberOfIterations, numberOfAnts); {Call to Ant Colony Optimization method to travel thru cities in the graph G }
		   Writeln; Writeln('The mimimum Cost =', bCost,' after ' , numberOfIterations,' Iteration with ', numberOfAnts,' Ants');
           displayBestRoutes(CityIndex, NumberOfCities, bCost, 'The best route starting from city 1 for the TSP:');
        End;
	Writeln('Press any key to continue....');
	ch := ReadKey;
End.
