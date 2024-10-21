using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int initialAge = 21;
    int deathAge = 101;
    [Serialize] int years = 79;

    // Start is called before the first frame update
    void Start()
    {
        // Display the initial age
        Debug.Log("Initial Age: " + initialAge);

        // Return and display age next year
        int nextYearAge = AgeNextYear(initialAge);
        Debug.Log("Age next year: " + nextYearAge);

        // Example of returning age after N years (in this case, let's say 5 years)

        int ageAfterNYears = AgeAfterNYears(initialAge, years);
        Debug.Log("Age after " + years + " years: " + ageAfterNYears);

        // Confirm with DebugLog by updating the age
        int updatedAge = UpdateAge(initialAge, years);
        Debug.Log("Updated age: " + updatedAge);

        //years until death, death age set to 100
        int yearsToDeath = YearsToDeath(updatedAge, deathAge);
        Debug.Log("Years left to reach death age " + deathAge + ": " + yearsToDeath);

        if (IsDead(updatedAge, deathAge))
        {
            Debug.Log("is now dead");
        }
        else
        {
            Debug.Log("is still alive");
        }

    }

    // Method to return age next year
    int AgeNextYear(int age)
    {
        return age++;
    }

    // Method to return age after N years
    int AgeAfterNYears(int age, int years)
    {
        return age + years;
    }

    // Method to update the age based on the number of years passed
    int UpdateAge(int age, int years)
    {
        return age + years;
    }
    int YearsToDeath(int age, int deathAge)
    {
        return deathAge - age;
    }
    bool IsDead(int age, int deathAge)
    {
        return age == deathAge;
    }
}

