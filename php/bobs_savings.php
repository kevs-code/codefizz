<?php

$annualExpenses = [
    "vacations" => 1000,
    "carRepairs" => 1000,
];

$monthlyExpenses = [
    "rent" => 1500,
    "utilities" => 200,
    "healthInsurance" => 200
];

$grossSalary = 48150;
$socialSecurity = $grossSalary * .062;

$incomeSegments = [[9700, .88], [29775, .78], [8675, .76]];

// Write your code below:

function net($seg)
{
  $income = $seg[0][0] * $seg[0][1]
  + $seg[1][0] * $seg[1][1]
  + $seg[2][0] * $seg[2][1];
  return $income;
}

$annualExp = $annualExpenses["vacations"] + $annualExpenses["carRepairs"];

$netIncome = net($incomeSegments);
$annualIncome = $netIncome - $socialSecurity - $annualExp;
echo $annualIncome . "\n";
$monthlyIncome = $annualIncome / 12;
$monthlyExp = $monthlyExpenses["rent"] + $monthlyExpenses["utilities"] +
$monthlyExpenses["healthInsurance"];
$monthlyIncome -= $monthlyExp;
echo $monthlyIncome . "\n";
$weeklyIncome = $monthlyIncome / 4.33;

$weeklyExpenses = [
    "gas" => 25,
    "food" => 90,
    "entertainment" => 47
];

$weeklyExp = $weeklyExpenses["gas"] + $weeklyExpenses["food"]
+ $weeklyExpenses["entertainment"];

$weeklyIncome -= $weeklyExp;
echo $weeklyIncome . "\n";

$bobSavings = 52 * $weeklyIncome;
echo "$" . round($bobSavings, 2);

/*
33368.2
880.68333333333
41.391070053888
$2152.34
*/

