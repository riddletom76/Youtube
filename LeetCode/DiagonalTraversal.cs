using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class DiagonalTraversal
    {
        public void GetResult(){
            List<List<int>> mat =  new List<List<int>> {new List<int> {1,2,3}, new List<int>{4,5,6}, new List<int>{7,8,9}};
            List<int> result = FindDiagonalTraversal(mat);
            foreach(var item in result){
                Console.WriteLine(item);
            }
        }

        private List<int> FindDiagonalTraversal(List<List<int>> mat)
        {
            List<int> result = new List<int>();
            bool goingUp = true;
            int i =0, j=0;
            for(int k=0;k<mat[0].Count() * mat.Count();){
                if(goingUp){
                    for(;i>=0 && j<mat[0].Count();i--,j++){
                        result.Add(mat[i][j]);
                        k++;
                    }
                    if(i <= 0){
                        i++;
                    }
                    if(j>=mat[0].Count()){
                        i++;
                        j--;
                    }
                }else{
                    for(;i<mat.Count() && j>=0;j--, i++){
                        result.Add(mat[i][j]);
                        k++;
                    }
                    if(j <= 0){
                        j++;
                    }
                    if(i >= mat.Count()){
                        i--;
                        j++;
                    }
                }
                goingUp = !goingUp;
            }
            return result;
        }
    }
}