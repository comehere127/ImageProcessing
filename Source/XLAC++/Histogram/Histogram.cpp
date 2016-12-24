#include<iostream>
#include<math.h>
using namespace std;
#define REP(i,N) for(int i=0;i<N;i++)
#define REP1(i,N) for(int i=1;i<=N;i++)
main(){
	freopen ("input.INP","r",stdin);
//	freopen ("out.OUT","w",stdout);
	int arrInput[6][6];
	int arrOutput[6][6];
	int arrHisto[10];
	int LUT[10];
	int total=6*6;
	REP(i,10){
		arrHisto[i]=0;
		LUT[i]=0;
	}

	while(!cin.eof()){
		REP(i,6)
		REP(j,6)
		cin>>arrInput[i][j];
	}
	
	//Input
	cout<<"Matrix input"<<endl;
	REP(i,6){
		REP(j,6)
		cout<<arrInput[i][j]<<" ";
		cout<<endl;
	}
	//Histogram
	REP(i,6)
	REP(j,6)
	REP(t,10)
		if(arrInput[i][j]==t)
			arrHisto[t]++;
	
	cout<<"Histogram"<<endl;
	REP(i,10){
		cout<<i<<" "<<arrHisto[i]<<endl;
	}
	//LUT	
	LUT[0]=arrHisto[0];
	cout<<"LUT->sum"<<endl;
	REP1(i,10){
		LUT[i]=arrHisto[i]+LUT[i-1];
	}
	REP(i,10)
		cout<<i<<" "<<LUT[i]<<endl;
	cout<<"LUT"<<endl;
	REP(i,10){
		LUT[i]=round(((double)LUT[i]*9/total));
		cout<<i<<" "<<LUT[i]<<endl;
	}
	//Equalazation
	REP(i,6)
	REP(j,6)
		arrOutput[i][j]=LUT[arrInput[i][j]];
	cout<<"OUTPUT"<<endl;
	REP(i,6){
		REP(j,6)
		cout<<arrOutput[i][j]<<" ";
		cout<<endl;
	}
}

