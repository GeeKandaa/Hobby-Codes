function [work_choice] = startDayV2(n, week, day, money, boat_count, pot_count, storm_count)
if storm_count > 0 
    weather_disp = 'bad';
else
    weather_disp = 'good';
end
work_choice = [0, 0, 0, 0];
for i=1:n
    fprintf('Week %d\nDay %d\n\nPlayer %d\n\nMoney: £%2.2f\nBoats: %d\nPots: %d\n\n',week, day, i, money(i), boat_count(i), pot_count(i));
    fprintf('The weather forecast looks %s\n\nWhat will you do today?\n\n 1 = Inshore \n 2 = Offshore \n 3 = Hotel', weather_disp); 
    work_choice(i) = input('\n\nInput = ');
    clc
end
