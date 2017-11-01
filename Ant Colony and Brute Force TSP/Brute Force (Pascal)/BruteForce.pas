(* A Pascal Program developed to implement Brute-Force Algorithm for Traveling Salesman Problem(TSP)
 * DEVELOPED BY: ADEJUMO TAOFEEK TUNDE
 * MATRIC NO: 14/CSH/0582
 *)
PROGRAM BruteForceTSP(input, output);
Const
	MAX	= 10; 
	INFINITY = 9999;
    NULL = 0;
TYPE
        tbl2Dim = Array[1..MAX, 1..MAX] of Integer;
        strTbl = Array[1..MAX] of String;
        tbl1Dim = Array[1..MAX] of Integer;
Var
	City :strTbl;
	CityIndex, RIndex, SIndex :tbl1Dim;
	NumberOfCities :Integer;
	Distance :tbl2Dim;
	minimumCost, bCost :Integer;

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
       End
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
				W[j,i] := W[i,j] (* Set the distance for the 2 cities in reverse order*)
             End 
       End       
End; 

Procedure Swap(Var X :Integer; Var Y :Integer);
Var
	temp :Integer;
Begin
	temp := X;
	X := Y;
	Y := temp;
End;

Function minimumValue(X :Integer; Y :Integer) :Integer;
Var
	temp :Integer;
Begin
	temp := X;
	if(temp > Y) then
		temp := Y;
	minimumValue := temp;	
End;

Procedure getBestRoutes(nIndex :tbl1Dim; N :Integer; mCost: Integer);
Var
	i : Integer;
Begin            
    If(bCost > mCost) Then
     Begin
       bCost := mCost; {Set new value for the best Cost}
       For i := 1  To N do
         Begin
             SIndex[i] := nIndex[i];
         End
     End
End;

Procedure displayRoutes(nIndex :tbl1Dim; N :Integer; mCost: Integer; strDisplay :String);
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

Function TSP_BruteForce(A :tbl1Dim; l :Integer; lengthSoFar :Integer; R :tbl1Dim) :Integer;
Var
	minCost :Integer;
	I :Integer;
	newLength :Integer;
    N :Integer;
Begin
    N := NumberOfCities;
	If (l = N) then
       Begin
		minCost := lengthSoFar + distance[A[n], A[1]]; {Finish by returning to city 1}
        displayRoutes(R, N, minCost, 'The route starting from city 1 for the TSP:');
        getBestRoutes(R, N, minCost);
       End
	Else
		Begin
			minCost := INFINITY;
			For I := l + 1 to n Do
				Begin
					Swap(A[l+1], A[i]); {Select A[i] as the next city}
					newLength := lengthSoFar + distance[A[l], A[l+1]];
                    R[L+1] := A[l+1];
					minCost := minimumValue(minCost, TSP_BruteForce(A, l+1, newLength, R));
					Swap(A[l+1], A[i]); {Undo Selection}
				End
		End;
	TSP_BruteForce := minCost;	
End;

Procedure InitIndices(Var R :tbl1Dim; Var S :tbl1Dim; N :Integer);
Var
	i : Integer;
Begin            
       R[1] := CityIndex[1]; S[1] := NULL;
       For i := 2  To N do
         Begin
             R[I] := NULL; S[I] := CityIndex[I];
         End;
       bCost := INFINITY; {Initialise the best cost}
End;
Begin
{Main program body starts here}
	Writeln('Welcome to Pascal Program developed to implement Brute Foce Algorithm for TSP:');
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
           InitIndices(RIndex, SIndex, NumberOfCities);
           Writeln('Brute Force Alogrithm Result: ');
		   minimumCost := TSP_BruteForce(CityIndex, 1, 0, RIndex); {call to brute force method to travel thru cities in the graph G }
		   Writeln; Writeln('The mimimum Cost =', minimumCost);
           displayRoutes(SIndex, NumberOfCities, minimumCost, 'The best route starting from city 1 for the TSP:');
        End;
	Writeln('Press any key to continue....');
	Readln;
End.
