function [ null ] = GAME_END(n, boat_count, pot_count, money )
clc
count = 0;
DrawnPlayers = [0,0,0,0];
null = 0;
END_GAME = 666;
END_SCORE = [0, 0, 0, 0];

for i=1:n
    END_SCORE(i) = (boat_count(i) * 75) + (pot_count(i) * 25) + money(i);
end

[M,I] = max(END_SCORE);
    
for i=1:n
    if M == END_SCORE(i)
        count = count + 1;
        DrawnPlayers(i) = 1;
    end
end
if count == 1
    t = timer('TimerFcn', 'stat=false; disp('''')',...
        'StartDelay',1);
    start(t)
    while END_GAME == 666
        clc
        for i=1:5
            fprintf('PLAYER %d WINS!\n', I)
            pause(0.1)
        end
    end
else if count > 1
        while END_GAME == 666
            clc
            fprintf('Its a draw between..\n')
            for i=1:n
                if DrawnPlayers(i) == 1
                    fprintf('Player %d, ', i);
                end
            end
            fprintf('\nThats lame.\n\nRematch?\n\n')
            END_GAME = input('Input a number to continue');
        end
    end
end
end

