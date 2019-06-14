function [ nowork, money ] = calc_EarningsV2(n,  nowork, storm, work_choice, money, pot_count )
if nowork == 0
    earnings = [0, 0, 0, 0];
    for i=1:n
        if storm == 0
            if work_choice(i) == 1
                earnings(i) = pot_count(i)*10;
                money(i) = earnings(i) + money(i);
            elseif work_choice(i) == 2
                    earnings(i) = pot_count(i)*20;
                    money(i) = earnings(i) + money(i);
            elseif work_choice(i) == 3
                earnings(i) = 15;
                money(i) = earnings(i) + money(i);
            end
        elseif storm == 1
                if work_choice(i) == 1
                    earnings(i) = pot_count(i)*5;
                    money(i) = earnings(i) + money(i);
                elseif work_choice(i) == 2
                        earnings(i) = -pot_count(i)*10;
                        money(i) = earnings(i) + money(i);
                elseif work_choice(i) == 3
                            earnings(i) = 15;
                            money(i) = earnings(i) + money(i);
                end
                
               
         end
    end
    for i=1:n
        if nowork == 0
            fprintf('Player %d, you earned £%3.2f today!\nYou now have £%3.2f\n\n', i, earnings(i), money(i));
        end
    end
else
    nowork = 0;
end
end