# Customize-MAUI-Carousel-Control

The .NET MAUI Carousel control offers an interactive way for users to view and select images from a collection. It features a range of customization options for arranging its items, enhancing both functionality and user experience. 

This sample demonstrates how to customize the MAUI Carousel Control in a .NET MAUI Application. You'll see  how to load items into the carousel, manage multiple items, and adjust the size of adjacent items, to a specified scale.

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## How to run the sample

1. Clone the sample and open it in Visual Studio 2022.
   
   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*

2. Register your license key in the App.cs file as demonstrated in the following code.

		public App()
		{
			//Register Syncfusion license
			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
		
			InitializeComponent();
		
			MainPage = new MainPage();
		}
		
	Refer to this [link](https://help.syncfusion.com/maui/licensing/overview) for more details.
	
3. Clean and build the application.

4. Run the application.

## Sample

```xaml
<StackLayout VerticalOptions="Center" Spacing="25">
    <carousel:SfCarousel x:Name="carousel" 
                         ItemsSource="{Binding CarouselItems}"
                         AllowLoadMore="True"
                         LoadMoreItemsCount="2"
                         ScaleOffset="0.4">
        <carousel:SfCarousel.LoadMoreView>
            <Grid BackgroundColor="LightBlue">
                <Label
                Text="Load more..."
                FontSize="14"
                TextColor="DeepPink"
                FontAttributes="Bold"
                HorizontalOptions="Center"
                VerticalOptions="Center" />
            </Grid>
        </carousel:SfCarousel.LoadMoreView>
    </carousel:SfCarousel>

    <Button Text="Load More" Clicked="Button_Clicked" WidthRequest="250"/>
</StackLayout>
```

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion's samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion's samples.