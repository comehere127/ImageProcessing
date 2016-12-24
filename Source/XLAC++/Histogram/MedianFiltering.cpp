#include<iostream>
#include<math.h>
#include<algorithm>
using namespace std;
#define REP(i,N) for(int i=0;i<N;i++)
#define REP1(i,N) for(int i=1;i<=N;i++)
main(){
	freopen ("input5.INP","r",stdin);
//	freopen ("out.OUT","w",stdout);
	int inputSize=6;
	int maskSize;
	int arrInput[inputSize][inputSize];
	double arrOutput[inputSize][inputSize];
	while(!cin.eof()){
		REP(i,inputSize)
		REP(j,inputSize)
		cin>>arrInput[i][j];
		
		cin>>maskSize;
	}
	cout<<"Matrix input"<<endl;
	REP(i,inputSize){
		REP(j,inputSize)
		cout<<arrInput[i][j]<<" ";
		cout<<endl;
	}
//	
//	int iExpandSize=maskSize/2;
//	int iNewSize=inputSize+2*iExpandSize;
//	int tmp[iNewSize][iNewSize];
//	REP(i,iNewSize)
//	REP(j,iNewSize){
//		if((i-iExpandSize)>=0 && (i+iExpandSize)<iNewSize &&(j-iExpandSize)>=0 && (j+iExpandSize)<iNewSize)
//			tmp[i][j]=arrInput[i-iExpandSize][j-iExpandSize];
//		else
//			tmp[i][j]=4;
//	}
//	cout<<"Matrix expand"<<endl;
//	REP(i,iNewSize){
//		REP(j,iNewSize)
//		cout<<tmp[i][j]<<" ";
//		cout<<endl;	
//	}
	int iSizeArr=maskSize*maskSize;
	int pos=0;
	int flag=0;
	int count=0;
	
	int arrTmp[inputSize][inputSize];
	while(pos<6){
		int limit=pos+maskSize;
		int tmp1[iSizeArr];			
		for(int i=pos;i<limit;i++)
		for(int j=pos;j<limit;j++)
		{
			tmp1[flag]=tmp[i][j];
			count++;
			flag++;
		}
		pos++;
		flag=0;
		int aaa;
		sort(tmp1,tmp1 + iSizeArr);
		if(iSizeArr%2==0){
			aaa=(tmp1[iSizeArr/2]+tmp1[(iSizeArr+2)/2])/2;
		}else{
			aaa=tmp1[(iSizeArr+1)/2];
		}
		cout<<aaa<<endl;
	}
}

