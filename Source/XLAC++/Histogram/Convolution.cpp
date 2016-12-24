#include<iostream>
#include<math.h>
#include<algorithm>
using namespace std;
#define REP(i,N) for(int i=0;i<N;i++)
#define REP1(i,N) for(int i=1;i<=N;i++)
#define REP2(i,N) for(int i=0;i<N;++i)
struct cm{
	int TopLeft=0,TopMid=0,TopRight = 0;
	int MidLeft=0, Pixel=0, MidRight=0;
	int BottomLeft=0, BottomMid=0, BottomRight=0;
	
};
main(){
	freopen ("input2.INP","r",stdin);
//	freopen ("out.OUT","w",stdout);
	int inputSize=6;
	int maskSize=3;
	int arrInput[inputSize][inputSize];
	int arrMaskX[maskSize][maskSize];
	int arrMaskY[maskSize][maskSize];
	double arrOutput[inputSize][inputSize];
	int arrOutputX[inputSize][inputSize];
	int arrOutputY[inputSize][inputSize];
	double iThreshold=12.8;
	while(!cin.eof()){
		//Input
		REP(i,inputSize)
		REP(j,inputSize)
			cin>>arrInput[i][j];
		//Mask X
		REP(i,maskSize)
		REP(j,maskSize)
			cin>>arrMaskX[i][j];
		//Mask Y
		REP(i,maskSize)
		REP(j,maskSize)
			cin>>arrMaskY[i][j];
		//Threshold
//		cin>>iThreshold;
	}
	cout<<"Matrix input"<<endl;
	REP(i,inputSize){
		REP(j,inputSize)
		cout<<arrInput[i][j]<<" ";
		cout<<endl;
	}
	cout<<"Matrix Kernel X"<<endl;
	REP(i,maskSize){
		REP(j,maskSize)
		cout<<arrMaskX[i][j]<<" ";
		cout<<endl;
	}
	cout<<"Matrix Kernel Y"<<endl;
	REP(i,maskSize){
		REP(j,maskSize)
		cout<<arrMaskY[i][j]<<" ";
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
	
	//Convol
//	int iKCenter=iNewSize/2;
//	REP2(x,iNewSize)
//	REP2(y,iNewSize)
//	REP2(i,iKCenter)
//	{
//		int ii=iKCenter-iExpandSize-i;
//		REP2(j,iKCenter){
//			int jj=iKCenter-iExpandSize-j;
//			int xx = x+(i-iKCenter);
//			int yy = y+(j-iKCenter);
//			
//			if(xx>=0 && xx< iNewSize && yy>=0 && yy< iNewSize)
//				arrOutput[x][y]+=arrInput[xx][yy]*arrMaskX[ii][jj];
//		}
//	}
//	
	//Kernel X
	cm cmX;
	cmX.TopLeft= arrMaskX[0][0];
	cmX.TopMid= arrMaskX[0][1];
	cmX.TopRight= arrMaskX[0][2];
	
	cmX.MidLeft = arrMaskX[1][0];
	cmX.Pixel = arrMaskX[1][1];
	cmX.MidRight = arrMaskX[1][2];
	
	cmX.BottomLeft = arrMaskX[2][0];
	cmX.BottomMid = arrMaskX[2][1];
	cmX.BottomRight = arrMaskX[2][2];
	
	int val=0;
	//Maxtrix X 
	for (int xTmp = 1; xTmp < iNewSize - 1; xTmp++)
		{
			for (int yTmp = 1; yTmp < iNewSize - 1; yTmp++)
			{
				val = tmp[xTmp - 1][yTmp - 1] * cmX.TopLeft + tmp[xTmp - 1][yTmp] * cmX.TopMid + tmp[xTmp - 1][yTmp + 1] * cmX.TopRight
										+ tmp[xTmp][yTmp - 1] * cmX.MidLeft + tmp[xTmp][yTmp] * cmX.Pixel + tmp[xTmp][yTmp+1] * cmX.MidRight
										+ tmp[xTmp + 1][ yTmp - 1] * cmX.BottomLeft + tmp[xTmp + 1][ yTmp] * cmX.BottomMid + tmp[xTmp + 1][ yTmp + 1] * cmX.BottomRight;
			arrOutputX[xTmp - 1][ yTmp - 1] = val;
		}
	}
	cout<<"Matrix Output X"<<endl;
	REP(i,inputSize){
		REP(j,inputSize)
		cout<<arrOutputX[i][j]<<" ";
		cout<<endl;
	}
	//Kernel Y
	cm cmY;
	cmY.TopLeft= arrMaskY[0][0];
	cmY.TopMid= arrMaskY[0][1];
	cmY.TopRight= arrMaskY[0][2];
	cmY.MidLeft = arrMaskY[1][0];
	cmY.Pixel = arrMaskY[1][1];
	cmY.MidRight = arrMaskY[1][2];
	cmY.BottomLeft = arrMaskY[2][0];
	cmY.BottomMid = arrMaskY[2][1];
	cmY.BottomRight = arrMaskY[2][2];
	//Maxtrix Y
	for (int xTmp = 1; xTmp < iNewSize - 1; xTmp++)
	{
			for (int yTmp = 1; yTmp < iNewSize - 1; yTmp++)
			{
				val = tmp[xTmp - 1][ yTmp - 1] * cmY.TopLeft + tmp[xTmp - 1][ yTmp] * cmY.TopMid + tmp[xTmp - 1][ yTmp + 1] * cmY.TopRight
					+ tmp[xTmp][ yTmp - 1] * cmY.MidLeft + tmp[xTmp][ yTmp] * cmY.Pixel + tmp[xTmp][ yTmp+1] * cmY.MidRight
					+ tmp[xTmp + 1][ yTmp - 1] * cmY.BottomLeft + tmp[xTmp + 1][ yTmp] * cmY.BottomMid + tmp[xTmp + 1][ yTmp + 1] * cmY.BottomRight;
			arrOutputY[xTmp - 1][ yTmp - 1] = val;
			}	
	}
	cout<<"Matrix Output Y"<<endl;
	REP(i,inputSize){
		REP(j,inputSize)
		cout<<arrOutputY[i][j]<<" ";
		cout<<endl;
	}
	
	double dTmp;
	REP(i,inputSize)
	REP(j,inputSize){
		dTmp=(double) sqrt(arrOutputX[i][j]*arrOutputX[i][j] + arrOutputY[i][j]*arrOutputY[i][j]);
		arrOutput[i][j]=roundf(dTmp*100)/100;
	}
	
	cout<<"Matrix Output"<<endl;
	REP(i,inputSize){
		REP(j,inputSize)
		cout<<arrOutput[i][j]<<" ";
		cout<<endl;
	}
	
	//Thresholding
	REP(i,inputSize)
	REP(j,inputSize){
		dTmp=arrOutput[i][j];
		if(dTmp>=iThreshold)
			dTmp=0;
		else
			dTmp=9;
		arrOutput[i][j] =dTmp;	
	}
	cout<<"Matrix Thresholding"<<endl;
	REP(i,inputSize){
		REP(j,inputSize)
		cout<<arrOutput[i][j]<<" ";
		cout<<endl;
	}
}
