CREATE DATABASE IF NOT EXISTS productlist;
USE productlist;
CREATE TABLE IF NOT EXISTS productlistdata(             
	PRODUCTID INT(11) AUTO_INCREMENT,
	NAME VARCHAR(255) NOT NULL,
	PRICE DECIMAL(5,2) NOT NULL,
	AMOUNT VARCHAR(255) NOT NULL,
	DESCRIPTION TEXT(999) NOT NULL,
	PRIMARY KEY(PRODUCTID)
);
CREATE TABLE IF NOT EXISTS productlistdataram(             
	PRODUCTID INT(11) AUTO_INCREMENT,
	NAME VARCHAR(255) NOT NULL,
	PRICE DECIMAL(5,2) NOT NULL,
	AMOUNT VARCHAR(255) NOT NULL,
	DESCRIPTION TEXT(999) NOT NULL,
	PRIMARY KEY(PRODUCTID)
);
CREATE TABLE IF NOT EXISTS receipts(
	ORDERID INT (11),
	NAME VARCHAR(255) NOT NULL,
	PRICE DECIMAL(9,2) NOT NULL,
	AMOUNT INT(11) NOT NULL
);
CREATE TABLE IF NOT EXISTS totalandtime(
	ORDERID INT (11),
	TOTAL DECIMAL(9,2) NOT NULL,
	created_at DATE  DEFAULT CURRENT_DATE
);

-- SELECT COUNT(PRODUCTID)
-- FROM productlistdata;
-- 
-- SELECT SUM(TOTAL)
-- FROM totalandtime
-- WHERE created_at BETWEEN '2022-03-15' AND '2022-03-16';
-- 
-- SELECT pl.PRODUCTID,
-- SUM(r.AMOUNT)
-- FROM receipts r
-- INNER JOIN productlistdata pl ON pl.NAME = r.NAME
-- INNER JOIN totalandtime tat ON tat.ORDERID = r.ORDERID
-- WHERE tat.created_at BETWEEN '2022-03-15' AND '2022-03-15'
-- GROUP BY pl.PRODUCTID;

-- INSERT INTO productlistdata (NAME, PRICE, AMOUNT, DESCRIPTION) VALUES
-- ('Double Espresso', '3.15', '862', 'A double espresso may also be listed as doppio, which is the Italian word for double. This drink is highly concentrated and strong.\n\nRatio: 2 shots of espresso\nCup: 3-4 oz. Demitasse Cup'),
-- ('Caffe Mocha', '4.65', '8606', 'The mocha is considered a coffee and hot chocolate hybrid. The chocolate powder or syrup gives it a rich and creamy flavor and cuts the acidity of the espresso.\n\nRatio: 1 shot of espresso + 1-2 oz. of chocolate syrup\powder + 1-3 oz. of steamed milk + 2-3 cm of foam or whipped cream\nCup: 6-8 oz. Irish Coffee Mug'),
-- ('Espresso', '2.15', '9731', 'The espresso, also known as a short black, is approximately 1 oz. of highly concentrated coffee. Although simple in appearance, it can be difficult to master.\n\nRatio: 1 shot of espresso\nCup: 2-4 oz. Espresso Cup'),
-- ('Black Eye', '4.35', 'Not available', 'The black eye is just the doubled version of the red eye and is very high in caffeine.\n\nRatio: 2 shots of espresso + 6 oz. of drip-brewed coffee\nCup: 8-10 oz. Coffee Mug'),
-- ('Americano', '2.55', '4275', 'Americanos are popular breakfast drinks and thought to have originated during World War II. Soldiers would add water to their coffee to extend their rations farther. The water dilutes the espresso while still maintaining a high level of caffeine.\n\nRatio: 1 shot of espresso + 3 oz. of hot water\nCup: 5-6 oz. Glass Coffee Mug'),
-- ('Long Black', '3.55', '9836', 'The long black is a similar coffee drink to the americano, but it originated in New Zealand and Australia. It generally has more crema than an americano.\n\nRatio: 2 shots of espresso + 3 oz. of hot water\nCup: 6-8 oz. Glass Coffee Mug'),
-- ('Macchiato', '3.05', '9708', 'The word “macchiato” means mark or stain. This is in reference to the mark that steamed milk leaves on the surface of the espresso as it is dashed into the drink. Flavoring syrups are often added to the drink according to customer preference.\n\nRatio: 1 shot of espresso + 1 to 2 teaspoons of steamed milk\nCup: 3 oz. Glass Espresso Cup'),
-- ('Long Macchiato', '3.70', '9845', 'The cortado takes the macchiato one step further by evenly balancing the espresso with warm milk in order to reduce the acidity.\n\nRatio: 1 shot of espresso + 1 oz. of warm milk + 1 cm of foam\nCup: 5 oz. Rocks Glass'),
-- ('Breve', '3.35', '8523', 'The breve provides a decadent twist on the average espresso, adding steamed half-and-half to create a rich and creamy texture.\n\nRatio: 1 shot of espresso + 3 oz. of steamed half-and-half + 1 cm of foam\nCup: 5-7 oz. Low Cup'),
-- ('Cappuccino', '3.85', '4170', 'This creamy coffee drink is usually consumed at breakfast time in Italy and is loved in the United States as well. It is usually associated with indulgence and comfort because of its thick foam layer and additional flavorings that can be added to it.\n\nRatio: 1-2 shots of espresso + 2 oz. of steamed milk + 2 oz. of foamed milk + sprinkling of chocolate powder (optional)\nCup: 6-8 oz. Cappuccino Mug'),
-- ('Flat White', '4.40', '9988', 'A flat white also originates from New Zealand and Australia and is very similar to a cappuccino but lacks the foam layer and chocolate powder. To keep the drink creamy rather than frothy, steamed milk from the bottom of the jug is used instead of from the top.\n\nRatio: 1 shot of espresso + 4 oz. of steamed milk\nCup: 6 oz. Glass Tumbler'),
-- ('Mocha', '4.10', '8769', 'The mocha is considered a coffee and hot chocolate hybrid. The chocolate powder or syrup gives it a rich and creamy flavor and cuts the acidity of the espresso.\n\nRatio: 1 shot of espresso + 1-2 oz. of chocolate syrup\powder + 1-3 oz. of steamed milk + 2-3 cm of foam or whipped cream\nCup: 6-8 oz. Irish Coffee Mug'),
-- ('Vienna', '3.90', '9964', 'There are a few variations on the Vienna, but one of the most common is made with two ingredients: espresso and whipped cream. The whipped cream takes the place of milk and sugar to provide a creamy texture.\n\nRatio: 1-2 shots of espresso + 2 oz. of whipped cream\nCup: 4-5 oz. Espresso Mug'),
-- ('Affogato', '4.50', '9967', 'Affogatos are more for a dessert coffee than a drink you would find at a cafe, but they can add a fun twist to your menu. They are made by pouring a shot of espresso over a scoop of vanilla ice cream to create a sweet after-meal treat.\n\nRatio: 1-2 shots of espresso + 1 scoop of vanilla ice cream\nCup: 5-7 oz. Dessert Dish'),
-- ('Cafe au Lait', '3.40', '8854', 'The cafe au lait is typically made with French press coffee instead of an espresso shot to bring out the different flavors in the coffee. It is then paired with scalded milk instead of steamed milk and poured at a 50\50 ratio.\n\nRatio: 5 oz. French press coffee + 5 oz. scalded milk\nCup: 12 oz. Coffee Mug'),
-- ('Iced Coffee', '4.10', '9642', 'Iced coffees become very popular in the summertime in the United States. The recipes do have some variance, with some locations choosing to interchange milk with water in the recipe. Often, different flavoring syrups will be added per the preference of the customer.\n\nRatio: 2 oz. drip coffee or espresso + 4 oz. of ice + 4-6 oz of milk or water + flavoring syrup to taste\nCup: 14 oz. Mixing Glass'),
-- ('Cafe Latte', '3.20', '9963', 'Cafe lattes are considered an introductory coffee drink since the acidity and bitterness of coffee is cut by the amount of milk in the beverage. Flavoring syrups are often added to the latte for those who enjoy sweeter drinks.\n\nRatio: 1 shot of espresso + 8-10 oz. of steamed milk + 1 cm of foam\nCup: 14 oz. Mixing Glass');
-- 

-- INSERT INTO top10 (NAME, QUANTITY) VALUES
-- ('Double Espresso', '0'),
-- ('Caffe Mocha', '0'),
-- ('Espresso', '0'),
-- ('Black Eye', '0'),
-- ('Americano', '0'),
-- ('Long Black', '0'),
-- ('Macchiato', '0'),
-- ('Long Macchiato', '0'),
-- ('Breve', '0'),
-- ('Cappuccino', '0'),
-- ('Flat White', '0'),
-- ('Mocha', '0'),
-- ('Vienna', '0'),
-- ('Affogato', '0'),
-- ('Cafe au Lait', '0'),
-- ('Iced Coffee', '0'),
-- ('Cafe Latte', '0');
