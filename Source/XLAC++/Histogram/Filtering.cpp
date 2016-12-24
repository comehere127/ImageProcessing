#include<iostream>
#include<math.h>
using namespace std;
#define REP(i,N) for(int i=0;i<N;i++)
#define REP1(i,N) for(int i=1;i<=N;i++)
struct cm{
	int TopLeft=0,TopMid=0,TopRight = 0;
	int MidLeft=0, Pixel=0, MidRight=0;
	int BottomLeft=0, BottomMid=0, BottomRight=0;
	
};
main(){
	freopen ("input4.INP","r",stdin);
//	freopen ("out.OUT","w",stdout);
	int inputSize=6;
	int maskSize=3;
	int arrInput[inputSize][inputSize];
	double arrOutput[inputSize][inputSize];
	int arrMask[maskSize][maskSize];
	int total=0;
	while(!cin.eof()){
		REP(i,inputSize)
		REP(j,inputSize)
		cin>>arrInput[i][j];
		
		//mask
		REP(i,maskSize)
		REP(j,maskSize)
		cin>>arrMask[i][j];
	}
	cout<<"Matrix input"<<endl;
	REP(i,inputSize){
		REP(j,inputSize)
		cout<<arrInput[i][j]<<" ";
		cout<<endl;
	}
	cout<<"Matrix mask"<<endl;
	REP(i,maskSize){
		REP(j,maskSize)
		cout<<arrMask[i][j]<<" ";
		cout<<endl;
	}
	int iExpandSize=maskSize/2;
	int iNewSize=inputSize+2*iExpandSize;
	int tmp[iNewSize][iNewSize];
	REP(i,iNewSize)
	REP(j,iNewSize){
		if((i-iExpandSize)>=0 && (i+iExpandSize)<iNewSize &&(j-iExpandSize)>=0 && (j+iExpandSize)<iNewSize)
			tmp[i][j]=arrInput[i-iExpandSize][j-iExpandSize];
		else
			tmp[i][j]=0;
	}
	cout<<"Matrix expand"<<endl;
	REP(i,iNewSize){
		REP(j,iNewSize)
		cout<<tmp[i][j]<<" ";
		cout<<endl;	
	}
	REP(i,maskSize)
		REP(j,maskSize)
		total+=arrMask[i][j];
	
	cm cmNew;
	cmNew.TopLeft= arrMask[0][0];
	cmNew.TopMid= arrMask[0][1];
	cmNew.TopRight= arrMask[0][2];
	cmNew.MidLeft = arrMask[1][0];
	cmNew.Pixel = arrMask[1][1];
	cmNew.MidRight = arrMask[1][2];
	cmNew.BottomLeft = arrMask[2][0];
	cmNew.BottomMid = arrMask[2][1];
	cmNew.BottomRight = arrMask[2][2];
	
	int val=0;
	//Maxtrix X 
	for (int xTmp = 1; xTmp < iNewSize - 1; xTmp++)
		{
			for (int yTmp = 1; yTmp < iNewSize - 1; yTmp++)
			{
				val = tmp[xTmp - 1][ yTmp - 1] * cmNew.TopLeft + tmp[xTmp - 1][ yTmp] * cmNew.TopMid + tmp[xTmp - 1][ yTmp + 1] * cmNew.TopRight
					+ tmp[xTmp][ yTmp - 1] * cmNew.MidLeft + tmp[xTmp][ yTmp] * cmNew.Pixel + tmp[xTmp][ yTmp] * cmNew.MidRight
					+ tmp[xTmp + 1][ yTmp - 1] * cmNew.BottomLeft + tmp[xTmp + 1][ yTmp] * cmNew.BottomMid + tmp[xTmp + 1][ yTmp + 1] * cmNew.BottomRight;
			arrOutput[xTmp - 1][ yTmp - 1] = val;
		}
	}
	
	cout<<"Matrix Output"<<endl;
	REP(i,inputSize){
		REP(j,inputSize)
		cout<<arrOutput[i][j]<<" ";
		cout<<endl;
	}
	double dTmp;
	cout<<"Matrix Output after divi total"<<endl;
	REP(i,inputSize){
		REP(j,inputSize){
			dTmp = (double)arrOutput[i][j]/total;
			cout<<roundf(dTmp*100)/100<<" ";
		}
		
		cout<<endl;
	}
}

