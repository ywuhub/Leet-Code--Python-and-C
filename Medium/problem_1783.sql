/*
    Table: Players

    +----------------+---------+
    | Column Name    | Type    |
    +----------------+---------+
    | player_id      | int     |
    | player_name    | varchar |
    +----------------+---------+
    player_id is the primary key for this table.
    Each row in this table contains the name and the ID of a tennis player.

    Table: Championships

    +---------------+---------+
    | Column Name   | Type    |
    +---------------+---------+
    | year          | int     |
    | Wimbledon     | int     |
    | Fr_open       | int     |
    | US_open       | int     |
    | Au_open       | int     |
    +---------------+---------+
    year is the primary key for this table.
    Each row of this table containts the IDs of the players who won one each tennis tournament of the grand slam.

    Write an SQL query to report the number of grand slam tournaments won by each player. Do not include the players who did not win any tournament.

    Return the result table in any order.
*/

SELECT player_id, 
       player_name, 
       SUM(
           CASE WHEN Wimbledon = player_id THEN 1 ELSE 0 END +
           CASE WHEN Fr_open = player_id THEN 1 ELSE 0 END +
           CASE WHEN US_open = player_id THEN 1 ELSE 0 END +
           CASE WHEN Au_open = player_id THEN 1 ELSE 0 END
        ) AS grand_slams_count
FROM Players, Championships
GROUP BY player_id
HAVING grand_slams_count > 0;