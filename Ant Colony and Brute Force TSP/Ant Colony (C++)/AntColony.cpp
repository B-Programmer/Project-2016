/* A C++ Program developed to implement Ant Colony Algorithm for Traveling Salesman Problem(TSP) *
 * DEVELOPED BY: ADEJUMO TAOFEEK TUNDE
 * MATRIC NO: 14/CSH/0582
 */
#include <process.h>
#include <cstdlib>
#include <iostream>
#include <ctype.h>
#include <math.h>
#define MAX 10 
#define	INFINIT 9999
#define ZERO 0

using namespace std;

	char City[MAX];
	int CityIndex[MAX];
	int NumberOfCities;
	int Distance[MAX][MAX];
	int bCost;

void initDistance(int W[][MAX], int N)
{ 
	int i, j;
    for(i = 0; i < N; i++)
    {
          for (j = 0; j < N; j++)
          {
              W[i][j] = ZERO; // Set the initial distance for the 2 cities to zero
          } 
    }
    bCost = INFINIT; //initialize the best Cost to Infinity
}

void ReadNodes(char Nodes[], int nIndex[], int N)
{
	int i;
    cout<<"Read in the names of all Nodes(Cities) in the graph G(V,E) for the TSP:\n";
       for (i = 0; i < N; i++)
       {
             cout<<"Read in the names of Node(City): "<<i+1<<endl;
             cin>>Nodes[i]; //store name in the Nodes array
             nIndex[i] = i; //store the name index in another array
       }            
}

void ReadDistance(int W[][MAX], int N, char nodes[])
{
	int i, j;
    initDistance(W, N);
	cout<<"Read in distance(Weight/Cost) between 2 Cities (u,v) in the graph G of TSP:\n";
       for (i = 0; i < N-1; i++)
       {
             for (j = i+1; j < N; j++)
             {
                 cout<<"Read in distance(Weight/Cost) between City: "<<i+1<<" and City: "<<j+1<<" for the TSP:"<<nodes[i]<<"-"<<nodes[j]<<endl;
                 cin>>W[i][j];
                 if (W[i][j] != ZERO) 
			     W[j][i] = W[i][j]; // Set the distance for the 2 cities in reverse order*)
             } 
       }       
}

void getBestRoutes(int nIndex[][MAX], int N, int mCost, int K)
{
	int i;
    if(bCost > mCost)
     {
       bCost = mCost; //Set new value for the best Cost
       for (i = 0; i < N; i++)
           CityIndex[i] = nIndex[K][i];
     }
}
void displayBestRoutes(int nIndex[], int N,  int mCost, char strDisplay[])
{
	int i;
       cout<<strDisplay;
       cout<<"\nCity: ";
       for (i = 0; i < N; i++)
       {
             cout<<City[nIndex[i]]<<"-";
       }
         cout<<City[0]<<" = "<<mCost<<endl;
}

int getDistance(int nIndex[][MAX], int v, int k)
{
    //Get the total distance represented by the ant movement in nIndex}
   int t, I;
    t = 0;
     for (I = 1; I < v; I++)
         t = t + Distance[nIndex[k][I-1]] [nIndex[k][I]];
     t = t + Distance[nIndex[k][v]][0];
     getBestRoutes(nIndex, v,  t, k); //Check if and get the best routes
   return t;
}

void DisplayRoutes(int nIndex[][MAX], int v, int k, char strDisplay[])
{
	int i;
    cout<<(strDisplay);
    cout<<"Ant "<<k+1<<" City: ";
       for (i = 0; i < v; i++)
         {
             cout<<City[nIndex[k][i]]<<"-";
         }
    cout<<City[0]<<" = "<< getDistance(nIndex, v, k);
}

void AntColony(int nIterations, int nAnts)
{
     int Alpha = 1, Beta = 2;
     double h[MAX][MAX], Gthoinit[MAX][MAX], thoinit[MAX][MAX];
     int I, J, N, C;
     double P[MAX], CumP[MAX];
     double SumP, r, e;
     int Count, K, V;
     int RIndex[MAX][MAX];
     int totalDistance[MAX];

   N = NumberOfCities; Count = 1;
   for (I = 0; I < N; I++)
   {
         for (J = 0; J < N; J++)
          {
               Gthoinit[I][J] = 1; //Initialize value of Global pheromones between cities}
          }
   }
label5:   K = 0; //Initialize no of ants}
          cout<<"\nIteration "<<Count<<":"<<endl;
label10:
   for (I = 0; I < N; I++)
   {
         for (J = 0; J < N; J++)
          {
               h[I][J] = ZERO;
               if(Distance[I][J] != ZERO) 
               h[I][J] = 1.0/Distance[I][J]; //{Initialize value of visibility between cities}
          }
   }
   for (I = 0; I < N; I++)
    {
         for (J = 0; J < N; J++)
          {
               thoinit[I][J] = Gthoinit[I][J]; //{Initialize value of Local pheromones between cities}
          }
    }

    C = 0;  // {Initialize the starting city as city 1}
    V = 0; RIndex[K][V] = C; //{Set the starting city as city 1 for ant K}
label20:
   for (I = 0; I < N; I++)
       h[I][C] = ZERO; //{Initialize value of visibility of the current City, C to NULL}
   //{Calculate the probabilities to visit other cities from the current city (C)}
    SumP = 0.0;
   for (J = 0; J < N; J++)
   {
         P[J] = (double)pow(thoinit[C][J], Alpha) * pow(h[C][J], Beta);
         SumP = SumP + P[J]; //{Initialize value of visibility of the current City, C to NULL}
   }
   //{Compute the probabilities of ant K going to another city from city C}
   for (J = 0; J < N; J++)
        P[J] = P[J]/SumP;
   //{Compute the Cummulative probabilities of ant K going to another city from city C}
   CumP[0] = P[0];
   for (J = 1; J < N; J++)
       CumP[J] = CumP[J-1] + P[J];
   //{* Generate a random number r for the choice of cities to be visited by comparing it with
    //* the value of the cummulative probabilities}
   //randomize;
   r = (1.0 - 0.0) * rand()/(RAND_MAX + 1.0);
   for (J = 1; J < N; J++)
    {
     if(r < CumP[J])
      {
           C = J; // {Get the next city index}
           goto label30;
      }
    }
label30:
   V = V + 1; RIndex[K][V] = C; //{Store the next city to visited}
   if(V < N) goto label20;
   DisplayRoutes(RIndex, V, K, "\nThe route starting from city 1 for the TSP:\n");
   totalDistance[K] = getDistance(RIndex, V, K); //{Get the total distance represented by the ant movement in RIndex}
   K = K + 1; //{Set the next ant K into operation}
   if(K < nAnts) goto label10;
   //{Using the total distance to update the global pheromones}
   e = 0.5; //{initialize the evaporation coefficient}
   for (I = 0; I < N; I++) 
    {
      for (J = 0; J < N; J++)
          Gthoinit[I][J] = (1 - e) * Gthoinit[I][J];
    }
   for (K = 0; K < nAnts; K++)
    {
       for (V = 1; V < N; V++)
        {
          Gthoinit[RIndex[K][V-1]][RIndex[K][V]] = Gthoinit[RIndex[K][V-1]][RIndex[K][V]] + 1.0/totalDistance[K];
         }
    }
   Count = Count + 1; //{Increase the number of Iteration}
   if(Count < nIterations) goto label5; //{Repeat operations for the next iteration}
}


int main(int argc, char *argv[])
{
    //Main program body starts here
	cout<<"Welcome to C++ Program developed to implement Ant Colony Algorithm for TSP:";
    cout<<"\n===============================================================================";
    cout<<"\nRead in Number(between 1 and 10) of Nodes(Cities) in Graph G(V,E) for the TSP: ";
    cin>>NumberOfCities;
    if ((NumberOfCities < 1) || (NumberOfCities > MAX))
        cout<<"Wrong Input! Please, Read in correct digit from 1 to 10:";
    else
		{
		   //*Construction of the  Graph G(V,E) for the TSP*)
		   ReadNodes(City, CityIndex, NumberOfCities); // Read in N nodes*)
		   ReadDistance(Distance, NumberOfCities, City); //Read in weight/cost of each edges*)
		   //*performing Brute Force Algorithm on the Graph for TSP*)
           //InitIndices(RIndex, SIndex, NumberOfCities);
           cout<<"\nAnt Colony Optimization Alogrithm Result I: ";
           int numberOfIterations = 50;
           int numberOfAnts = 5;
		   AntColony(numberOfIterations, numberOfAnts);// {Call to Ant Colony Optimization method to travel thru cities in the graph G }
		   cout<<"\nThe mimimum Cost = "<<bCost<<" after "<<numberOfIterations<<" Iteration with "<<numberOfAnts<<" Ants";
		   displayBestRoutes(CityIndex, NumberOfCities, bCost,"\nThe best route starting from city 1 for the TSP:");
  		}    
    system("PAUSE");
    return EXIT_SUCCESS;
}
