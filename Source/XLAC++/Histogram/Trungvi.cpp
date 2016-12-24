#include<iostream>
#include<math.h>
#include<algorithm>
using namespace std;
#define REP(i,N) for(int i=0;i<N;i++)
#define REP1(i,N) for(int i=1;i<=N;i++)
main(){
	freopen ("input.INP","r",stdin);
//	freopen ("out.OUT","w",stdout);
	int inputSize=6;
	int arrInput[inputSize][inputSize];
	int iSizeArr=inputSize*inputSize;
	int arr[iSizeArr];
	while(!cin.eof()){
		REP(i,inputSize)
		REP(j,inputSize)
		cin>>arrInput[i][j];
	}
	cout<<"Matrix input"<<endl;
	REP(i,inputSize){
		REP(j,inputSize)
		cout<<arrInput[i][j]<<" ";
		cout<<endl;
	}
	int flag=0;
	REP(i,inputSize)
		REP(j,inputSize){
			arr[flag]=arrInput[i][j];
			flag++;	
		}
	
	sort(arr,arr + iSizeArr);
	REP(i,iSizeArr)
		cout<<i+1<<"--"<<arr[i]<<endl;
	
//	cout<<(arr[iSizeArr/2]+arr[(iSizeArr+2)/2])/2<<"-";	
	
}
