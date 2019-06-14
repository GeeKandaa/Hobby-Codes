function [storm, hurricane, storm_count, crit_val] = StormTest(storm, hurricane, storm_count, crit_val)
    chance = rand;
    if chance > crit_val
        storm = 0;
        storm_count = 0;
        crit_val = crit_val*2;
    else if chance <= crit_val
            fprintf('\n\nUh-oh, a storm!\n\n')
        storm_count = storm_count + 1;
        storm = 1;
        crit_val = crit_val/2;
        end
    end
    if storm_count == 3
        clc
        fprintf('\n\nOH NO! A HURRICANE!!\n\n')
        hurricane = 1;
        storm_count = 0;
        crit_val = 1/6;
    end
end