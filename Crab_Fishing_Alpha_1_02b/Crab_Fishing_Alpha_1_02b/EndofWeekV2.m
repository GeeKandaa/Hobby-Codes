function [money, boat_count, pot_count] = EndofWeekV2(n, week, money, boat_count, pot_count)
    boats_bought = [0, 0, 0, 0];
    pots_bought = [0, 0, 0, 0];
    for i=1:n
        fprintf('END OF WEEK %d\n\nPlayer %d\nMoney: £%2.2f\nBoats: %d\nPots: %d\n\n',week, i, money(i), boat_count(i), pot_count(i));
        boats_bought(i) = input('How many boats do you want to buy?\n(Boats cost £150)');
        legal = 0;
        while legal == 0
            if (money(i) >= boats_bought(i)*150)
                boat_count(i) = boat_count(i) + boats_bought(i);
                money(i) = money(i) - 150*boats_bought(i);
                legal = 1;
            else
                clc
                fprintf('END OF WEEK %d\n\nPlayer %d\nMoney: £%2.2f\nBoats: %d\nPots: %d\n\n',week, i, money(i), boat_count(i), pot_count(i));
                boats_bought(i) = input('Learn how to finance better, you dont have enough money for that\nHow many boats do you want to buy?\n(Boats cost £150)');
            end
        end
        clc 
        fprintf('END OF WEEK %d\n\nPlayer %d\nMoney: £%2.2f\nBoats: %d\nPots: %d\n\n',week, i, money(i), boat_count(i), pot_count(i));
        legal = 0;
        pots_bought(i) = input('Player 1\nHow many pots do you want to buy?\n(Pots cost £50)');
        while legal ==0
            if (money(i) >= pots_bought(i)*50)
                pot_count(i) = pot_count(i) + pots_bought(i);
                money(i) = money(i) - 50*pots_bought(i);
                legal = 1;
                clc
            else
                clc
                fprintf('END OF WEEK %d\n\nPlayer %d\nMoney: £%2.2f\nBoats: %d\nPots: %d\n\n',week, i, money(i), boat_count(i), pot_count(i));
                pots_bought(i) = input('Learn how to finance better, you dont have enough money for that\nHow many pots do you want to buy?\n(Pots cost £50)');
            end
        end
    end
    fprintf('END OF WEEK %d\n\n', week);
    for i=1:n
        fprintf('Player %d\nMoney: £%2.2f\nBoats: %d\nPots: %d\n\n',i, money(i), boat_count(i), pot_count(i));
    end
    cont = input('Input any number to continue');
end

