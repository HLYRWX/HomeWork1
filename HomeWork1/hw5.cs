package lianxi;

import java.util.Scanner;

public class Panduanfenshudengji
{

    public static void main(String[] args)
    {
        // TODO Auto-generated method stub
        Scanner in= new Scanner(System.in);
        int score =in.nextInt();
        System.out.println(grade(score));
		in.close();
    }

    public static char grade(int score)
    {
        // TODO Auto-generated method stub
        return (score >= 90) ? 'A' : ((score >= 60) ? 'B' : 'C');
    }

}

