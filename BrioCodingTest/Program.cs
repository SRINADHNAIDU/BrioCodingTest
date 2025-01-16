

public class Program
{
    public static void Main()
    {
        Palindrome();
        ReverseAnArrayByKDistance();
        QueueUsingTwoStacks();
    }

    private static void Palindrome()
    {
        Console.WriteLine("Enter a string to check if it is a palindrome: ");
        string? inputString = Console.ReadLine();
        if (string.IsNullOrEmpty(inputString))
        {
            Console.WriteLine("Please enter a valid string");
            return;
        }
        bool isPalindrome = CheckPalindrome(inputString, 0, inputString.Length-1);
        if (isPalindrome)
        {
            Console.WriteLine("The input string is a palindrome");
        }
        else
        {
            Console.WriteLine("The input string is not a palindrome");
        }
    }

    private static bool CheckPalindrome(string input, int start, int end)
    {
        if (start >= end)
        {
            return true;
        }
        return (input[start] == input[end]) && CheckPalindrome(input, start + 1, end - 1);
    }

    private static void ReverseAnArrayByKDistance()
    {
        Console.WriteLine("Enter the number of elements in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter the elements of the array: ");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Enter the value of k: ");
        int k = Convert.ToInt32(Console.ReadLine());
        ReverseArray(arr, k);
        Console.WriteLine("The reversed array is: ");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    private static void ReverseArray(int[] arr, int k)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i += k)
        {
            int left = i;
            int right = Math.Min(i + k - 1, n - 1);
            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }
    }

    private static void QueueUsingTwoStacks()
    {
        Console.WriteLine("Implementing a queue using two stacks");
        StackQueue queue = new StackQueue();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
        queue.Enqueue(4);
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
    }



}

class StackQueue
{
    private Stack<int> stack1 = new Stack<int>();
    private Stack<int> stack2 = new Stack<int>();

    public void Enqueue(int x)
    {
        stack1.Push(x);
    }

    public int Dequeue()
    {
        if (stack1.Count == 0 && stack2.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return -1;
        }
        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }
        return stack2.Pop();
    }
}