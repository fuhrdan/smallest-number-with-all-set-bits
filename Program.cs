//*****************************************************************************
//** 3370. Smallest Number With All Set Bits                        leetcode **
//*****************************************************************************
//** A number with bits all shining bright,                                  **
//** We seek the next that’s pure with light.                                **
//** From n we climb to find that flair                                      **
//** All ones in binary, beyond compare.                                     **
//*****************************************************************************

int smallestNumber(int n) {
    int powerOfLove = 1;
    while(powerOfLove - 1 < n)
    {
        powerOfLove <<= 1;
    }
    return powerOfLove - 1;
}