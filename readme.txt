questions:
1. Is that right if I saved multiple controllers?
2. Q2. square: large number doesn't work. (9999 works, 99999 broke)
3. Bonus questions:
------------
Thought process:
 1) id/14=decimal number round down
 2) 1)*1.13 = Total
 3) Output 3 strings
1) 2) 3) are three get methods? could they be put into one controller?
------------
Codes:
public static decimal Floor(decimal d)
int interval = (int)Math.Floor(difference / increment);

How could they be structured into a method like the following:

public IEnumerable<int> Get(int id)
{
  return new int[] { id/14 rounded down };
}



