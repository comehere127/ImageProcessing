#include<iostream>
#include<math.h>
using namespace std;
#define REP(i,N) for(int i=0;i<N;i++)
#define REP1(i,N) for(int i=1;i<=N;i++)
int main(){
	freopen ("input3.INP","r",stdin);
//	freopen ("out.OUT","w",stdout);
	int inputSize=6;
	int arrInput[inputSize][inputSize];
	double arrOutput[inputSize][inputSize];
	int c=1;
	double dGamma;
	int a,b;
	while(!cin.eof()){
		REP(i,inputSize)
		REP(j,inputSize)
		cin>>arrInput[i][j];
		
		cin>>dGamma;
	}
	//Input
	cout<<"Matrix input"<<endl;
	REP(i,6){
		REP(j,6)
		cout<<arrInput[i][j]<<" ";
		cout<<endl;
	}
	//Power-Law Transformation
	double val;
	REP(i,inputSize)
	REP(j,inputSize){
		val=(double)pow(arrInput[i][j],dGamma);
		arrOutput[i][j]=roundf(val);
	}
	
	cout<<"Power-Law Transformation"<<endl;
	REP(i,6){
		REP(j,6)
		cout<<arrOutput[i][j]<<" ";
		cout<<endl;
	}
	//Negative transformation
	REP(i,inputSize)
	REP(j,inputSize){
		arrOutput[i][j]=255-arrInput[i][j];
	}
	
	cout<<"Negative transformation"<<endl;
	REP(i,6){
		REP(j,6)
		cout<<arrOutput[i][j]<<" ";
		cout<<endl;
	}
	//Log transformation
	
	//Gray-level slicing transformation
	
	
}

