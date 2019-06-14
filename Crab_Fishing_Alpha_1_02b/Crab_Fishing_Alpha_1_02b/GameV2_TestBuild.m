game = 1;
while game == 1
clc
%PLAYER 1 STATS INIT
boat_count = [1, 1, 1, 1];
money = [150, 150, 150, 150];
pot_count = [1, 1, 1, 1];

%WEATHER INIT
storm_count = 0;
crit_val = 1/6;
storm = 0;
hurricane = 0;

%GAME INIT
nowork = 0;
day = 1;
week = 1;
legal = 0;
while legal == 0
n = input('How many players?\n\nInput = ');
if n < 4 && n > 0
    legal = 1;
else
    n = input('INVALID NUMBER OF PLAYERS\nHow many players?\n\nInput = ');
end
end

    
while week < 5
    while day < 8
    %start day
    clc
    %function startDay
    [work_choice] = startDayV2(n, week, day, money, boat_count, pot_count, storm_count);
    %storm?
    clc
    [storm, hurricane, storm_count, crit_val] = StormTest(storm, hurricane, storm_count, crit_val);
    %hurricane?
    [ money, hurricane, boat_count, pot_count, nowork] = HurricaneTestV2(n, nowork, money, hurricane, boat_count, pot_count, work_choice );
    %Calculate earnings
    [ nowork, money ] = calc_EarningsV2(n, nowork, storm, work_choice, money, pot_count );
    day = day + 1;
    cont = input('Input any number to continue\n\nInput = ');
    end

    %END OF WEEK 1
    %Buy boats/pots?
    clc
    [money, boat_count, pot_count] = EndofWeekV2(n, week, money, boat_count, pot_count);
        week = week + 1;
        day = 1;
end

[ null ] = GAME_END(n, boat_count, pot_count, money );
week = 1;
day = 1;
end
