WinformScottPlotMultichart

This is a little demo project, that I have done to correctly implement multiple interactive charts in a single Windows Form. 

The project is simple, and lacking more than one security check; but, for its purposes, it works, enough for me to explain my doubts and, I hope, for Scott and others that will spend some time answering to my questions...

In short, the project is made up of the following parts:
	- the data Model, with some classes describing the entities that play the game:
		ChartFormModel contains a whole chart form, with the attributes that are common to all charts in it: Title and subtitle of form, and number of charts embedded. ChartFormModel has a List of Charts.
	
		ChartModel describe a single chart, with his attributes (not all of them, only the more common ones): The title of the single graph, the title of the Y axis and the minimum and maximum values of the scale of the Y axis; I may have to set them up manually. Then I have a flag to show the legend, and the percentage of the height of the form that I want to reserve for the individual chart. Finally, I have two lists: ChartData and ChartNotes
		
			ChartDataModel contains the attributes of a single set of data that I want to plot in the chart: I have a PlotType, that for now can be Scatter or Bar, the color of the curve and the data label. The property "Series" contains a string that is a filter value for retrieving the data from a database.
			
			ChartNotesModel contains the attributes of the notes that I may want to insert in the chart: the values, X and Y; if the Y value is not null, then the annotation is horizontal, otherwise it will be vertical. But the annotation will be drawn only if his X value falls in the range of the Xs of the data.
	
	- a ChartControl, that is a wrapper for a ScottPlot.Plot();
	- a ChartDTO, Data Transfer Object, that contains the logic for retrieving the chart data.
	
This simple demo explain my goal, that is create a template for charting, using the data from a series of database tables... 