﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public static class State
{
    public static bool musicIsPlaying = true;
    public static int noOfAstronauts = 1;
    public static int costToHire = 700000;
    public static int money = 5000000;

    public static bool playerDidWin;
    public static int investmentCost;
    public static int returnCost;

    public static bool instructionsArePlaying;

    public static bool disableSkip;

    public static bool showHowMuchMoneyPlayerMade = false;
    
    public static string[] instructions =
    {
        "markwatney$ Establishing connection to Earth...",
        "markwatney$ Establishing connection to Earth... \nmarkwatney$ Hi! I’m Matt.",
        "markwatney$ Establishing connection to Earth... \nmarkwatney$ Hi! I’m Matt. \nmarkwatney$ I am the first human to have set foot on Mars.",
        "markwatney$ Establishing connection to Earth... \nmarkwatney$ Hi! I’m Matt. \nmarkwatney$ I am the first human to have set foot on Mars.\nmarkwatney$ I run a company back on earth called 'The First Martian Inc.'",
        "markwatney$ Establishing connection to Earth... \nmarkwatney$ Hi! I’m Matt. \nmarkwatney$ I am the first human to have set foot on Mars.\nmarkwatney$ I run a company back on earth called 'The First Martian Inc.' \nmarkwatney$ As you can probably see, we find ourselves on Mars.",
        "markwatney$ Establishing connection to Earth... \nmarkwatney$ Hi! I’m Matt. \nmarkwatney$ I am the first human to have set foot on Mars.\nmarkwatney$ I run a company back on earth called 'The First Martian Inc.' \nmarkwatney$ As you can probably see, we find ourselves on Mars. \nmarkwatney$ Over the past few years, companies like mine have worked tirelessly to help expand the space industry.",
        "markwatney$ Establishing connection to Earth... \nmarkwatney$ Hi! I’m Matt. \nmarkwatney$ I am the first human to have set foot on Mars.\nmarkwatney$ I run a company back on earth called 'The First Martian Inc.' \nmarkwatney$ As you can probably see, we find ourselves on Mars. \nmarkwatney$ Over the past few years, companies like mine have worked tirelessly to help expand the space industry. \nmarkwatney$ Space seems very profitable, if cared for through great leadership and management.",
        "markwatney$ Establishing connection to Earth... \nmarkwatney$ Hi! I’m Matt. \nmarkwatney$ I am the first human to have set foot on Mars.\nmarkwatney$ I run a company back on earth called 'The First Martian Inc.' \nmarkwatney$ As you can probably see, we find ourselves on Mars. \nmarkwatney$ Over the past few years, companies like mine have worked tirelessly to help expand the space industry. \nmarkwatney$ Space seems very profitable, if cared for through great leadership and management. \nmarkwatney$ That’s where we need your help.",
        "markwatney$ Establishing connection to Earth... \nmarkwatney$ Hi! I’m Matt. \nmarkwatney$ I am the first human to have set foot on Mars.\nmarkwatney$ I run a company back on earth called 'The First Martian Inc.' \nmarkwatney$ As you can probably see, we find ourselves on Mars. \nmarkwatney$ Over the past few years, companies like mine have worked tirelessly to help expand the space industry. \nmarkwatney$ Space seems very profitable, if cared for through great leadership and management. \nmarkwatney$ That’s where we need your help. \nmarkwatney$ By hiring astronauts and controlling the rocket to land safely, you can help the company make great profits!",
        "markwatney$ Establishing connection to Earth... \nmarkwatney$ Hi! I’m Matt. \nmarkwatney$ I am the first human to have set foot on Mars.\nmarkwatney$ I run a company back on earth called 'The First Martian Inc.' \nmarkwatney$ As you can probably see, we find ourselves on Mars. \nmarkwatney$ Over the past few years, companies like mine have worked tirelessly to help expand the space industry. \nmarkwatney$ Space seems very profitable, if cared for through great leadership and management. \nmarkwatney$ That’s where we need your help. \nmarkwatney$ By hiring astronauts and controlling the rocket to land safely, you can help the company make great profits! \nmarkwatney$ While doing this, our company can urbanise the planet of mars.",
        "markwatney$ Establishing connection to Earth... \nmarkwatney$ Hi! I’m Matt. \nmarkwatney$ I am the first human to have set foot on Mars.\nmarkwatney$ I run a company back on earth called 'The First Martian Inc.' \nmarkwatney$ As you can probably see, we find ourselves on Mars. \nmarkwatney$ Over the past few years, companies like mine have worked tirelessly to help expand the space industry. \nmarkwatney$ Space seems very profitable, if cared for through great leadership and management. \nmarkwatney$ That’s where we need your help. \nmarkwatney$ By hiring astronauts and controlling the rocket to land safely, you can help the company make great profits! \nmarkwatney$ While doing this, our company can urbanise the planet of mars. \nmarkwatney$ But completing this task successfully will not be easy.",
        "markwatney$ Establishing connection to Earth... \nmarkwatney$ Hi! I’m Matt. \nmarkwatney$ I am the first human to have set foot on Mars.\nmarkwatney$ I run a company back on earth called 'The First Martian Inc.' \nmarkwatney$ As you can probably see, we find ourselves on Mars. \nmarkwatney$ Over the past few years, companies like mine have worked tirelessly to help expand the space industry. \nmarkwatney$ Space seems very profitable, if cared for through great leadership and management. \nmarkwatney$ That’s where we need your help. \nmarkwatney$ By hiring astronauts and controlling the rocket to land safely, you can help the company make great profits! \nmarkwatney$ While doing this, our company can urbanise the planet of mars. \nmarkwatney$ But completing this task successfully will not be easy. \nmarkwatney$ You will face various obstacles, such as Martian rocks and fuel shortages.",
        "markwatney$ Establishing connection to Earth... \nmarkwatney$ Hi! I’m Matt. \nmarkwatney$ I am the first human to have set foot on Mars.\nmarkwatney$ I run a company back on earth called 'The First Martian Inc.' \nmarkwatney$ As you can probably see, we find ourselves on Mars. \nmarkwatney$ Over the past few years, companies like mine have worked tirelessly to help expand the space industry. \nmarkwatney$ Space seems very profitable, if cared for through great leadership and management. \nmarkwatney$ That’s where we need your help. \nmarkwatney$ By hiring astronauts and controlling the rocket to land safely, you can help the company make great profits! \nmarkwatney$ While doing this, our company can urbanise the planet of mars. \nmarkwatney$ But completing this task successfully will not be easy. \nmarkwatney$ You will face various obstacles, such as Martian rocks and fuel shortages. \nmarkwatney$ The goal of each level is to safely transport the rocket from one launchpad to another.",
        "markwatney$ Establishing connection to Earth... \nmarkwatney$ Hi! I’m Matt. \nmarkwatney$ I am the first human to have set foot on Mars.\nmarkwatney$ I run a company back on earth called 'The First Martian Inc.' \nmarkwatney$ As you can probably see, we find ourselves on Mars. \nmarkwatney$ Over the past few years, companies like mine have worked tirelessly to help expand the space industry. \nmarkwatney$ Space seems very profitable, if cared for through great leadership and management. \nmarkwatney$ That’s where we need your help. \nmarkwatney$ By hiring astronauts and controlling the rocket to land safely, you can help the company make great profits! \nmarkwatney$ While doing this, our company can urbanise the planet of mars. \nmarkwatney$ But completing this task successfully will not be easy. \nmarkwatney$ You will face various obstacles, such as Martian rocks and fuel shortages. \nmarkwatney$ The goal of each level is to safely transport the rocket from one launchpad to another. \nmarkwatney$ If you decide to use many astronauts, you will produce larger profits.",
        "markwatney$ Establishing connection to Earth... \nmarkwatney$ Hi! I’m Matt. \nmarkwatney$ I am the first human to have set foot on Mars.\nmarkwatney$ I run a company back on earth called 'The First Martian Inc.' \nmarkwatney$ As you can probably see, we find ourselves on Mars. \nmarkwatney$ Over the past few years, companies like mine have worked tirelessly to help expand the space industry. \nmarkwatney$ Space seems very profitable, if cared for through great leadership and management. \nmarkwatney$ That’s where we need your help. \nmarkwatney$ By hiring astronauts and controlling the rocket to land safely, you can help the company make great profits! \nmarkwatney$ While doing this, our company can urbanise the planet of mars. \nmarkwatney$ But completing this task successfully will not be easy. \nmarkwatney$ You will face various obstacles, such as Martian rocks and fuel shortages. \nmarkwatney$ The goal of each level is to safely transport the rocket from one launchpad to another. \nmarkwatney$ If you decide to use many astronauts, you will produce larger profits. \nmarkwatney$ Be cautious as you progress, however, as losing too many astronauts can lead to failure.",
        "markwatney$ Establishing connection to Earth... \nmarkwatney$ Hi! I’m Matt. \nmarkwatney$ I am the first human to have set foot on Mars.\nmarkwatney$ I run a company back on earth called 'The First Martian Inc.' \nmarkwatney$ As you can probably see, we find ourselves on Mars. \nmarkwatney$ Over the past few years, companies like mine have worked tirelessly to help expand the space industry. \nmarkwatney$ Space seems very profitable, if cared for through great leadership and management. \nmarkwatney$ That’s where we need your help. \nmarkwatney$ By hiring astronauts and controlling the rocket to land safely, you can help the company make great profits! \nmarkwatney$ While doing this, our company can urbanise the planet of mars. \nmarkwatney$ But completing this task successfully will not be easy. \nmarkwatney$ You will face various obstacles, such as Martian rocks and fuel shortages. \nmarkwatney$ The goal of each level is to safely transport the rocket from one launchpad to another. \nmarkwatney$ If you decide to use many astronauts, you will produce larger profits. \nmarkwatney$ Be cautious as you progress, however, as losing too many astronauts can lead to failure. \nmarkwatney$ The rocket is controlled using the keys W or Spacebar for upward thrust as well as A and D for tilting it left and right respectively.",
        "markwatney$ Establishing connection to Earth... \nmarkwatney$ Hi! I’m Matt. \nmarkwatney$ I am the first human to have set foot on Mars.\nmarkwatney$ I run a company back on earth called 'The First Martian Inc.' \nmarkwatney$ As you can probably see, we find ourselves on Mars. \nmarkwatney$ Over the past few years, companies like mine have worked tirelessly to help expand the space industry. \nmarkwatney$ Space seems very profitable, if cared for through great leadership and management. \nmarkwatney$ That’s where we need your help. \nmarkwatney$ By hiring astronauts and controlling the rocket to land safely, you can help the company make great profits! \nmarkwatney$ While doing this, our company can urbanise the planet of mars. \nmarkwatney$ But completing this task successfully will not be easy. \nmarkwatney$ You will face various obstacles, such as Martian rocks and fuel shortages. \nmarkwatney$ The goal of each level is to safely transport the rocket from one launchpad to another. \nmarkwatney$ If you decide to use many astronauts, you will produce larger profits. \nmarkwatney$ Be cautious as you progress, however, as losing too many astronauts can lead to failure. \nmarkwatney$ The rocket is controlled using the keys W or Spacebar for upward thrust as well as A and D for tilting it left and right respectively. \nmarkwatney$ Good luck on your mission, fellow Martian!",
        "markwatney$ Establishing connection to Earth... \nmarkwatney$ Hi! I’m Matt. \nmarkwatney$ I am the first human to have set foot on Mars.\nmarkwatney$ I run a company back on earth called 'The First Martian Inc.' \nmarkwatney$ As you can probably see, we find ourselves on Mars. \nmarkwatney$ Over the past few years, companies like mine have worked tirelessly to help expand the space industry. \nmarkwatney$ Space seems very profitable, if cared for through great leadership and management. \nmarkwatney$ That’s where we need your help. \nmarkwatney$ By hiring astronauts and controlling the rocket to land safely, you can help the company make great profits! \nmarkwatney$ While doing this, our company can urbanise the planet of mars. \nmarkwatney$ But completing this task successfully will not be easy. \nmarkwatney$ You will face various obstacles, such as Martian rocks and fuel shortages. \nmarkwatney$ The goal of each level is to safely transport the rocket from one launchpad to another. \nmarkwatney$ If you decide to use many astronauts, you will produce larger profits. \nmarkwatney$ Be cautious as you progress, however, as losing too many astronauts can lead to failure. \nmarkwatney$ The rocket is controlled using the keys W or Spacebar for upward thrust as well as A and D for tilting it left and right respectively. \nmarkwatney$ Good luck on your mission, fellow Martian! \n \nPress enter to continue..."

    };

}
