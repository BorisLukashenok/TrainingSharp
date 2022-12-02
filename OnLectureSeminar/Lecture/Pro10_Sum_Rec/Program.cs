int SumRec(int n,int m)
{
    
    if(m==n ) return n;
    else return m+SumRec(n,m-1);
}

Console.WriteLine(SumRec(4,8));