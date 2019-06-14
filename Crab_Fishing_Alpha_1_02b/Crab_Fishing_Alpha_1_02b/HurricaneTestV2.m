function [ money, hurricane, boat_count, pot_count, nowork] = HurricaneTestV2(n, nowork, money, hurricane, boat_count, pot_count, work_choice )
   
    if hurricane == 1
        hurricane = 0;
        nowork = 1;
        lost_boats = [0, 0, 0, 0];
        lost_pots = [0, 0, 0, 0]; 
        restore_boats = [0, 0, 0, 0];
        restore_pots = [0, 0, 0, 0];
        
        for i=1:n
            lost_boats(i) = boat_count(i)-1;
            lost_pots(i) = pot_count(i)-1;
        end
        
        boat_count = [1, 1, 1, 1];
        pot_count = [1, 1, 1, 1];
        
        
        for i=1:n
            if work_choice(i) ~= 3
            legal = 0;
            clc
            fprintf('HURRICANE!!\n\nPlayer %d\n\nOnly 1 of your boats and pots were spared by the storm..!\n\n', i)
            fprintf('Money: £%2.2f\nBoats: %d\nPots: %d\n\n', money(i), boat_count(i), pot_count(i));
            restore_boats(i) = input('How many boats would you like to repair?\n(It costs £100 to repair each boat)\nInput = ');
            while legal == 0
                if money(i) > 100*restore_boats(i)
                    if restore_boats(i) < lost_boats(i) + 1
                        boat_count(i) = boat_count(i) + restore_boats(i);
                        money(i) = money(i) - 100*restore_boats(i);
                        legal = 1;
                    else
                        clc
                        fprintf('HURRICANE!!\n\nPlayer %d\n\nOnly 1 of your boats and pots were spared by the storm..!\n\n', i)
                        fprintf('Money: £%2.2f\nBoats: %d\nPots: %d\n\n', money(i), boat_count(i), pot_count(i));
                        restore_boats(i) = input('You cant repair more boats than you actually own, dipshit. Lets try this again \n \nHow many boats would you like to repair?\n(It costs £100 to repair each boat)\nInput = ');
                    end
                else
                    clc
                    fprintf('HURRICANE!!\n\nPlayer %d\n\nOnly 1 of your boats and pots were spared by the storm..!\n\n', i)
                    fprintf('Money: £%2.2f\nBoats: %d\nPots: %d\n\n', money(i), boat_count(i), pot_count(i));
                    restore_boats(i) = input('Not enough money, dipshit. Lets try this again \n \nHow many boats would you like to repair?\n(It costs £100 to repair each boat)\nInput = ');
                end
            end
            legal = 0;
            clc
            fprintf('HURRICANE!!\n\nPlayer %d\n\nOnly 1 of your boats and pots were spared by the storm..!\n\n', i)
            fprintf('Money: £%2.2f\nBoats: %d\nPots: %d\n\n', money(i), boat_count(i), pot_count(i));
            restore_pots(i) = input('How many pots would you like to repair?\n(It costs £30 to repair each pot)\nInput = ');
            while legal == 0
                if money(i) > 30*restore_pots(i)
                    if restore_pots(i) < lost_pots(i) + 1
                        money(i) = money(i) - 30*restore_pots(i);
                        pot_count(i) = pot_count(i) + restore_pots(i);
                        legal = 1;
                    else
                        clc
                        fprintf('HURRICANE!!\n\nPlayer %d\n\nOnly 1 of your boats and pots were spared by the storm..!\n\n', i)
                        fprintf('Money: £%2.2f\nBoats: %d\nPots: %d\n\n', money(i), boat_count(i), pot_count(i));
                        restore_pots(i) = input('You cant repair more pots than you actually own, dipshit. Lets try this again \n \nHow many pots would you like to repair?\n(It costs £30 to repair each pot)\nInput = ');
                    end
                else
                    clc
                    fprintf('HURRICANE!!\n\nPlayer %d\n\nOnly 1 of your boats and pots were spared by the storm..!\n\n', i)
                    fprintf('Money: £%2.2f\nBoats: %d\nPots: %d\n\n', money(i), boat_count(i), pot_count(i));
                    restore_pots(i) = input('Not enough money, dipshit. Lets try this again \n \nHow many pots would you like to repair?\n(It costs £30 to repair each pot)\nInput = ');
                    clc
                end
            end
            else
                clc
                fprintf('HURRICANE!!\n\nPlayer %d \nYou sheltered from the storm inside the hotel.\nNone of your boats and pots were affected by the hurricane!\n\n', i);
                cont = input('Input any number to continue');
            end
        end
    end
end