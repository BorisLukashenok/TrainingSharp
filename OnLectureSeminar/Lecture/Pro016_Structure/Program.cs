string emp = string.Empty;
string[] tree={emp,"/","*","10","-","+",emp,emp,"4","2","1","3"};

void InOrderTraversal(int pos=1)
{
if(pos<tree.Length)
{
    int left=2*pos;
    int right=2*pos+1;
    if(left<tree.Length && !string.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
    System.Console.WriteLine(tree[pos]);
    if(right<tree.Length && !string.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
}
}

InOrderTraversal();