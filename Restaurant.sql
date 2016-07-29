/* Object: Table [dbo].[Menu] */
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[MenuID] [int] IDENTITY (100, 1) NOT NULL,
	[MenuName] [varchar](300) NOT NULL,
	[ShortDecs] [varchar](150) NOT NULL,
	[Rate] [decimal](5,2),
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF

/*Insert Data */
INSERT INTO Menu (MenuName, ShortDecs)
VALUES ('Side Dish:-' , ' ' )

INSERT INTO Menu (MenuName, ShortDecs, Rate)
VALUES ('Butter Milk' , 'flavored Indian buttermilk. It is made with plain yogurt, green chili, cilantro and spices.' , 15.00)

INSERT INTO Menu (MenuName, ShortDecs, Rate)
VALUES ('Sambharo' , 'Cabbage sambharo is nothing but the Gujarati style warm cabbage salad.' , 20.00)

INSERT INTO Menu (MenuName, ShortDecs, Rate)
VALUES ('Chutney' , 'Coriander chutney or Cilantro chutney or Dhaniya Chutney Whatever name you want give it.' , 10.00)

INSERT INTO Menu (MenuName, ShortDecs, Rate)
VALUES ('Pickle' , 'Aam Ka Achaar(Spicy Raw Mango Pickle)' , 10.00)

INSERT INTO Menu (MenuName, ShortDecs)
VALUES ('Dishes:-' , ' ' )

INSERT INTO Menu (MenuName, ShortDecs, Rate)
VALUES ('Mini Dish' , 'Gujarati Mini Thali(Dish) Recipe Ideas is the place where you can find a few of the vast range of Gujarati recipes.' , 150.00)

INSERT INTO Menu (MenuName, ShortDecs, Rate)
VALUES ('Full Dish(2 Side Dish and 1 Dessert of your choice)' , 'Gujarati Thali(Dish) Recipe Ideas is the place where you can find the vast range of Gujarati recipes.' , 180.00)

INSERT INTO Menu (MenuName, ShortDecs)
VALUES ('Dessert:-' , ' ' )

INSERT INTO Menu (MenuName, ShortDecs, Rate)
VALUES ('Rice kheer' , 'Instant rice kheer recipe made with cooked, leftover rice, milk and sweetened condensed milk.' , 25.00)

INSERT INTO Menu (MenuName, ShortDecs, Rate)
VALUES ('Ice Cream(Dry-Fruit, Kaju-pista)' , 'Easy to make basic and eggless ice cream recipe. ' , 15.00)

INSERT INTO Menu (MenuName, ShortDecs, Rate)
VALUES ('Lassi(Mango,Pineapple,Regular' , 'a chilled beverage to beat the summer heat. It is made from mangoes, sugar and yogurt with pinch of cardamom powder.' , 20.00)






/* Object: Table [dbo].[ButterMilk] */
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ButterMilk](
	[MenuID] [int]  IDENTITY (100,1)NOT NULL,
	[MenuName] [varchar](300) NOT NULL,
	[DetailedDecs] [varchar](500) NOT NULL,
	[Rate] [decimal](5,2) NOT NULL,
	 CONSTRAINT [PK_ButterMilk] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF

/*Insert Data */
INSERT INTO ButterMilk (MenuName, DetailedDecs, Rate)
VALUES ('Butter Milk' , 'flavored Indian buttermilk. It is made with plain yogurt, green chili, cilantro and spices. In this hot summer, you need something to beat the heat. Chaas is perfect beverage in hot weather. All the ingredients are up to taste; you can change the quantity as per liking. This is how we like it and I am sharing with you.' , 15.00)


/* Object: Table [dbo].[Sambharo] */
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sambharo](
	[MenuID] [int]  IDENTITY (100,1)NOT NULL,
	[MenuName] [varchar](300) NOT NULL,
	[DetailedDecs] [varchar](500) NOT NULL,
	[Rate] [decimal](5,2) NOT NULL,
	 CONSTRAINT [PK_Sambharo] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF

/*Insert Data */
INSERT INTO Sambharo (MenuName, DetailedDecs, Rate)
VALUES ('Sambharo' , 'Cabbage sambharo is nothing but the Gujarati style warm cabbage salad. It is very quick to make and requires very few ingredients. This is my go to accompaniment salad recipe when I am making only roti and subzi in the meal.' , 20.00)

/* Object: Table [dbo].[Chutney] */
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chutney](
	[MenuID] [int]  IDENTITY (100,1)NOT NULL,
	[MenuName] [varchar](300) NOT NULL,
	[DetailedDecs] [varchar](500) NOT NULL,
	[Rate] [decimal](5,2) NOT NULL,
	 CONSTRAINT [PK_Chutney] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF

/*Insert Data */
INSERT INTO Chutney (MenuName, DetailedDecs, Rate)
VALUES ('Chutney' , 'Coriander chutney or Cilantro chutney or Dhaniya Chutney Whatever name you want give it. This is a dipping sauce for vadas, pakoras or samosas and also used in chaat items. Addition of a teaspoon of oil prevents chutney to tuning into blackish color by the time.' , 10.00)

/* Object: Table [dbo].[Pickle] */
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pickle](
	[MenuID] [int]  IDENTITY (100,1)NOT NULL,
	[MenuName] [varchar](300) NOT NULL,
	[DetailedDecs] [varchar](500) NOT NULL,
	[Rate] [decimal](5,2) NOT NULL,
	 CONSTRAINT [PK_Pickle] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF

/*Insert Data */
INSERT INTO Pickle (MenuName, DetailedDecs, Rate)
VALUES ('Pickle' , 'Aam Ka Achaar is simple recipe of a spicy raw mango pickle made from homemade pickle masala. Pickle-making process can be a very easy task, if you have the right guidance and the perfect recipe. With extensive guidance from my mother and mother-in-law I have managed to attain perfection in the pickle-making process.' , 10.00)

/* Object: Table [dbo].[MiniDish] */
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MiniDish](
	[MenuID] [int]  IDENTITY (100,1)NOT NULL,
	[MenuName] [varchar](300) NOT NULL,
	[DetailedDecs] [varchar](500) NOT NULL,
	[Rate] [decimal](5,2) NOT NULL,
	 CONSTRAINT [PK_MiniDish] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF

/* Insert Data */
INSERT INTO MiniDish (MenuName, DetailedDecs, Rate)
VALUES ('Mini Dish' , 'Gujarati Mini Thali Recipe Ideas is the place where you can find a few of the vast range of Gujarati recipes.  Ever since I have started this thali expedition, starting from the Great Indian Thali, I have been excited to explore the cuisines from various other regions. Hence started with home ground Gujarat. ' , 150.00)

/* Object: Table [dbo].[FullDish] */
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FullDish](
	[MenuID] [int]  IDENTITY (100,1)NOT NULL,
	[MenuName] [varchar](300) NOT NULL,
	[DetailedDecs] [varchar](500) NOT NULL,
	[Rate] [decimal](5,2) NOT NULL,
	 CONSTRAINT [PK_FullDish] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF

/* Insert Data */
INSERT INTO FullDish (MenuName, DetailedDecs, Rate)
VALUES ('Full Dish(2 Side Dish and 1 Dessert of your choice)' , 'Gujarati Thali(Dish) Recipe Ideas is the place where you can find the vast range of Gujarati recipes. Ever since I have started this thali expedition, starting from the Great Indian Thali, I have been excited to explore the cuisines from various other regions. Hence started with home ground Gujarat. ' , 180.00)

/* Object: Table [dbo].[RiceKheer] */
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RiceKheer](
	[MenuID] [int]  IDENTITY (100,1)NOT NULL,
	[MenuName] [varchar](300) NOT NULL,
	[DetailedDecs] [varchar](500) NOT NULL,
	[Rate] [decimal](5,2) NOT NULL,
	 CONSTRAINT [PK_RiceKheer] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF

/* Insert Data */
INSERT INTO RiceKheer (MenuName, DetailedDecs, Rate)
VALUES ('Rice kheer' , 'Kheer with condensed milk – instant rice kheer recipe made with cooked, leftover rice, milk and sweetened condensed milk. The condensed milk provides sweetness as well as makes the kheer creamy. Also it is already thick, so we don’t need to boil for the longer time to get the right consistency. Hence it saves a lot of time.' , 25.00)

/* Object: Table [dbo].[IceCream] */
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IceCream](
	[MenuID] [int]  IDENTITY (100,1)NOT NULL,
	[MenuName] [varchar](300) NOT NULL,
	[DetailedDecs] [varchar](500) NOT NULL,
	[Rate] [decimal](5,2) NOT NULL,
	 CONSTRAINT [PK_IceCream] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF

/* Insert Data */
INSERT INTO IceCream (MenuName, DetailedDecs, Rate)
VALUES ('Ice Cream(Dry-Fruit, Kaju-pista)' , 'Easy to make basic and eggless ice cream recipe. Store bought ones are smooth and light but not rich or creamy unless you are having it at local ice cream parlor. Since this is reach ice cream, two scoops of it is more than enough per person. ' , 15.00)

/* Object: Table [dbo].[Lassi] */
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lassi](
	[MenuID] [int]  IDENTITY (100,1)NOT NULL,
	[MenuName] [varchar](300) NOT NULL,
	[DetailedDecs] [varchar](500) NOT NULL,
	[Rate] [decimal](5,2) NOT NULL,
	 CONSTRAINT [PK_Lassi] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF


INSERT INTO Lassi (MenuName, DetailedDecs, Rate)
VALUES ('Lassi(Mango,Pineapple,Regular' , 'A chilled beverage to beat the summer heat. It is made from mangoes, sugar and yogurt with pinch of cardamom powder. Mango lassi or aam ki lassi is thick, rich and creamy with lots of mango flavor. It is perfect for this summer. It is very refreshing and cooling beverage. You can have it as a breakfast instead of your breakfast smoothie.' , 20.00)


Select * from Menu
Select * from Sambharo
Select * from Pickle
Select * from Chutney
Select * from ButterMilk
Select * from MiniDish
Select * from FullDish
Select * from RiceKheer
Select * from IceCream
Select * from Lassi
