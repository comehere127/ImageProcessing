#include<iostream>
#include<math.h>
using namespace std;
#define REP(i,N) for(int i=0;i<N;i++)
#define REP1(i,N) for(int i=1;i<=N;i++)
int getMin(double input, double* arr);
main(){
	freopen ("input1.INP","r",stdin);
//	freopen ("out.OUT","w",stdout);
	int sizeInput=6;
	int arrInput[sizeInput][sizeInput];
	int arrRefer[sizeInput][sizeInput];
	int arrOutput[sizeInput][sizeInput];
	int arrHistoInput[10];
	int arrHistoRefer[10];
	int LUT[10];
	double hInput[10];
	double hRefer[10];
	int total=sizeInput*sizeInput;
	REP(i,10){
		arrHistoInput[i]=0;
		arrHistoRefer[i]=0;
		LUT[i]=0;
		hRefer[i]=0;
		hInput[i]=0;
	}

	while(!cin.eof()){
		//input
		REP(i,sizeInput)
		REP(j,sizeInput)
		cin>>arrInput[i][j];
		
		//refer
		REP(i,sizeInput)
		REP(j,sizeInput)
		cin>>arrRefer[i][j];
	}
	
	//Input
	cout<<"Matrix input"<<endl;
	REP(i,sizeInput){
		REP(j,sizeInput)
		cout<<arrInput[i][j]<<" ";
		cout<<endl;
	}
	REP(i,sizeInput)
	REP(j,sizeInput)
	REP(t,10){
		if(arrInput[i][j]==t)
			arrHistoInput[t]++;
	}

	cout<<"Histogram input"<<endl;
	REP(i,10){
		cout<<i<<" "<<arrHistoInput[i]<<endl;
	}

	hInput[0]=arrHistoInput[0];
	REP1(i,10){
		hInput[i]=arrHistoInput[i]+hInput[i-1];
	}
	
	//Refer
	cout<<"Matrix refer"<<endl;
	REP(i,sizeInput){
		REP(j,sizeInput)
		cout<<arrRefer[i][j]<<" ";
		cout<<endl;
	}
	REP(i,sizeInput)
	REP(j,sizeInput)
	REP(t,10){
		if(arrRefer[i][j]==t)
			arrHistoRefer[t]++;
	}
	cout<<"Histogram refer"<<endl;
	REP(i,10){
		cout<<i<<" "<<arrHistoRefer[i]<<endl;
	}
	hRefer[0]=arrHistoRefer[0];
//	cout<<hRefer[0];
	REP1(i,10){
		hRefer[i]=arrHistoRefer[i]+hRefer[i-1];
	}
	
	cout<<"Equalize input"<<endl;
	REP(i,10){
		hInput[i]=(double)hInput[i]/total;
		cout<<i<<" "<<hInput[i]<<endl;
	}
	
	cout<<"Equalize refer"<<endl;
	REP(i,10){
		hRefer[i]=(double)hRefer[i]/total;
		cout<<i<<" "<<hRefer[i]<<endl;
	}
	double iTmp=0;
	REP(i,10){
		iTmp=hInput[i];
		LUT[i]=getMin(iTmp,hRefer);
	}
	
	//LUT
	cout<<"LUT"<<endl;
	REP(i,10)
		cout<<i<<"-"<<LUT[i]<<endl;
	
}
int getMin(double input, double* arr){
	int posMin=0;
	double arrTmp[10];
	REP(i,10){
		arrTmp[i]=fabs(input-arr[i]);
	}
		
	double min=arrTmp[0];
	REP(i,10)
		if(arrTmp[i]<min){
			min=arrTmp[i];
			posMin=i;
		}
	return posMin;
}

