/* A C++ Program developed to implement Brute Force Algorithm for Traveling Salesman Problem(TSP) *
 * DEVELOPED BY: ADEJUMO TAOFEEK TUNDE
 * MATRIC NO: 14/CSH/0582
 */         
#include <cstdlib>
#include <iostream>
#include <ctype.h>
#define MAX 10 
#define	INFINITY 9999
#define ZERO 0

using namespace std;

	char City[MAX];
	int CityIndex[MAX], RIndex[MAX], SIndex[MAX];
	int NumberOfCities;
	int Distance[MAX][MAX];
	int minimumCost, bCost;

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
void InitIndices(int R[], int S[], int N)
{
	int I;
    R[0] = CityIndex[0]; S[0] = ZERO;
       for (I = 1; I < N; I++)
         {
             R[I] = ZERO; S[I] = CityIndex[I];
         }
         bCost = INFINITY; //Initialize best cost           
} 

void Swap(int& X, int& Y)
{
	int temp;
	temp = X;
	X = Y;
	Y = temp;
}
int minimumValue(int X, int Y)
{
	int temp;
	temp = X;
	if(temp > Y)
		temp = Y;
	return temp;	
}
void getBestRoutes(int nIndex[], int N, int mCost)
{
	int i;
    if(bCost > mCost)
     {
       bCost = mCost; //Set new value for the best Cost
       for (i = 0; i < N; i++)
           SIndex[i] = nIndex[i];
     }
}
void displayRoutes(int nIndex[], int N,  int mCost, char strDisplay[])
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

int TSP_BruteForce(int A[], int l, int lengthSoFar, int R[])
{
	int minCost, I, newLength, N;

    N = NumberOfCities;
	if (l == N-1)
    {
		minCost = lengthSoFar + Distance[A[N-1]][A[0]]; //Finish by returning to city 1
        displayRoutes(R, N, minCost,"\nThe route starting from city 1 for the TSP:");
        getBestRoutes(R, N, minCost);
    }
	else
	{
			minCost = INFINITY;
			for (I = l + 1; I < N; I++)
			{
					Swap(A[l+1], A[I]); //Select A[i] as the next city}
					newLength = lengthSoFar + Distance[A[l]][A[l+1]];
                    R[l+1] = A[l+1];
					minCost = minimumValue(minCost, TSP_BruteForce(A, l+1, newLength, R));
					Swap(A[l+1], A[I]); //Undo Selection}
			}
	}
	return minCost;	
}
int main(int argc, char *argv[])
{
    //Main program body starts here
	cout<<"Welcome to C++ Program developed to implement Brute Foce Algorithm for TSP:";
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
           InitIndices(RIndex, SIndex, NumberOfCities);
           cout<<"\nBrute Force Alogrithm Result I: ";
		   minimumCost = TSP_BruteForce(CityIndex, ZERO, ZERO, RIndex); //call to brute force method to travel thru cities in the graph G }
		   cout<<"\nThe mimimum Cost = "<< minimumCost;
		   displayRoutes(SIndex, NumberOfCities, bCost,"\nThe best route starting from city 1 for the TSP:");
  		}

    system("PAUSE");
    return EXIT_SUCCESS;
}
