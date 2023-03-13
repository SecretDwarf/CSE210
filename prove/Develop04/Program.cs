using System;

Menu m = new Menu();
int action = -1;

while(!m.IsLastAction(action))
{
    IO.Clear();
    m.Dsiplay();
    action = m.RequestAction();
    Activity activity = null;
    IO.clear();
    switch (action)
    {
        case 1:
            activity =  new ActivityBreathing("Breathing Activity", "/nThis activity will");
            break;
        case 2:
            activity =  new ActivityReflection("Reflection Activity", "/nThis activity will");
            break;
        case 3:
            activity =  new ActivityListing("Listing Activity", "/nThis activity will");
            break;
        case 4:
            System.Environment.Exit(0);
            break;
    }
}
