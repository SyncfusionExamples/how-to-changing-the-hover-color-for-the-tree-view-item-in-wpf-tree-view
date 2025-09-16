# How to change the hover color for the TreeViewItem in WPF TreeView?

## About the sample

This sample illustrates how to change the hover color for the TreeViewItem in TreeView.

In [WPF TreeView](https://www.syncfusion.com/wpf-controls/treeview) (SfTreeView), when the mouse is hovered on the items, it will be highlighted in gray color by default. You can change the mouse hover color for the items by writing style for the items using the target type [TreeViewItem](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.TreeView.TreeViewItem.html).


```Xaml
<Window.Resources>
    <BooleanToVisibilityConverter x:Key="boolToVisibilityConverter"/>
    
    <DataTemplate x:Key="busyIndicatorTemplate">
        <syncfusion:SfBusyIndicator x:Name="PART_BusyIndicator"
                                    IsBusy="True"
                                    AnimationType="DotCircle"
                                    ViewboxWidth="{TemplateBinding Width}"
                                    VerticalContentAlignment="Center"
                                    VerticalAlignment="Center">
        </syncfusion:SfBusyIndicator>
    </DataTemplate>

    <Style TargetType="syncfusion:TreeViewItem">
        <Setter Property="Background" Value="White"/>
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="{x:Type syncfusion:TreeViewItem}">
                    <Grid x:Name="ROOT" Background="{TemplateBinding Background}">
                        <VisualStateManager.VisualStateGroups>
                            <VisualStateGroup x:Name="DropStates">
                                <VisualState x:Name="Normal"/>
                                <VisualState x:Name="DropAsChild">
                                    <Storyboard>
                                        <ObjectAnimationUsingKeyFrames BeginTime="00:00:00"
                                                                       Duration="00:00:00"
                                                                       Storyboard.TargetName="BorderContent"
                                                                       Storyboard.TargetProperty="Background">
                                            <DiscreteObjectKeyFrame KeyTime="00:00:00">
                                                <DiscreteObjectKeyFrame.Value>
                                                    <SolidColorBrush Color="#D2DFF2" />
                                                </DiscreteObjectKeyFrame.Value>
                                            </DiscreteObjectKeyFrame>
                                        </ObjectAnimationUsingKeyFrames>
                                        <ObjectAnimationUsingKeyFrames BeginTime="00:00:00"
                                                                       Duration="00:00:00"
                                                                       Storyboard.TargetName="BorderContent"
                                                                       Storyboard.TargetProperty="BorderBrush">
                                            <DiscreteObjectKeyFrame KeyTime="00:00:00">
                                                <DiscreteObjectKeyFrame.Value>
                                                    <SolidColorBrush Color="#2B579A"/>
                                                </DiscreteObjectKeyFrame.Value>
                                            </DiscreteObjectKeyFrame>
                                        </ObjectAnimationUsingKeyFrames>
                                        <ObjectAnimationUsingKeyFrames BeginTime="00:00:00"
                                                                       Duration="00:00:00"
                                                                       Storyboard.TargetName="BorderContent"
                                                                       Storyboard.TargetProperty="BorderThickness">
                                            <DiscreteObjectKeyFrame KeyTime="00:00:00">
                                                <DiscreteObjectKeyFrame.Value>
                                                    <Thickness>1</Thickness>
                                                </DiscreteObjectKeyFrame.Value>
                                            </DiscreteObjectKeyFrame>
                                        </ObjectAnimationUsingKeyFrames>
                                        <ObjectAnimationUsingKeyFrames BeginTime="00:00:00"
                                                                       Duration="00:00:00"
                                                                       Storyboard.TargetName="PART_ExpanderView"
                                                                       Storyboard.TargetProperty="Background">
                                            <DiscreteObjectKeyFrame KeyTime="00:00:00">
                                                <DiscreteObjectKeyFrame.Value>
                                                    <SolidColorBrush Color="#D2DFF2" />
                                                </DiscreteObjectKeyFrame.Value>
                                            </DiscreteObjectKeyFrame>
                                        </ObjectAnimationUsingKeyFrames>
                                    </Storyboard>
                                </VisualState>
                            </VisualStateGroup>
                        </VisualStateManager.VisualStateGroups>
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition MaxWidth="{TemplateBinding IndentationWidth}"/>
                            <ColumnDefinition Width="Auto"/>
                            <ColumnDefinition Width="*"/>
                            <ColumnDefinition Width="Auto"/>
                        </Grid.ColumnDefinitions>
                        <Border x:Name="BorderContent"  
                                BorderThickness="{TemplateBinding BorderThickness}"
                                BorderBrush="{TemplateBinding BorderBrush}"/>

                        <Border x:Name="PART_HoverBorder" 
                                Visibility="Collapsed" 
                                Margin="1"
                                Background="LightBlue"/>

                        <StackPanel x:Name="PART_IndentContainer"
                                    Panel.ZIndex="0"
                                    Orientation="Horizontal"
                                    Grid.Column="0">
                            <Rectangle x:Name="PART_IndentLine" 
                                       StrokeDashArray="2,2"
                                       HorizontalAlignment="Stretch"
                                       Visibility="Hidden">
                            </Rectangle>
                        </StackPanel>

                        <Grid x:Name="PART_LineGrid"
                              Grid.Column="1"
                              Panel.ZIndex="0"
                              Width="{TemplateBinding ExpanderWidth}"
                              Visibility="Hidden">
                            <Rectangle x:Name="PART_HorizontalLine" 
                                       StrokeDashArray="2,2"
                                       Margin="10,0,0,0"
                                       Width="10"
                                       VerticalAlignment="Center" />
                            <Rectangle x:Name="PART_VerticalLine" 
                                       StrokeDashArray="2,2"
                                       HorizontalAlignment="Stretch"/>
                        </Grid>

                        <ContentControl x:Name="PART_ExpanderView"
                                        Focusable="False"
                                        Width="{TemplateBinding ExpanderWidth}"
                                        Visibility="{Binding HasChildNodes, Converter={StaticResource boolToVisibilityConverter}}"
                                        ContentTemplate="{TemplateBinding ExpanderTemplate}">
                        </ContentControl>

                        <syncfusion:TreeNodeView x:Name="PART_ContentView" Grid.Column="2"
                                                 Margin="4,0,4,0"
                                                 VerticalAlignment="Center"
                                                 Focusable="False"
                                                 ContentTemplate="{TemplateBinding ItemTemplate}">
                        </syncfusion:TreeNodeView>

                        <Border x:Name="PART_DragLine" Grid.ColumnSpan="3" Visibility="Collapsed" BorderBrush="#2B579A" />

                    </Grid>

                    <ControlTemplate.Triggers>
                        <Trigger Property="FullRowSelect" Value="True">
                            <Setter Property="Grid.Column" TargetName="BorderContent" Value="0"/>
                            <Setter Property="Grid.ColumnSpan" TargetName="BorderContent" Value="4"/>
                            <Setter Property="Grid.Column" TargetName="PART_HoverBorder" Value="0"/>
                            <Setter Property="Grid.ColumnSpan" TargetName="PART_HoverBorder" Value="4"/>
                        </Trigger>
                        <MultiTrigger>
                            <MultiTrigger.Conditions>
                                <Condition Property="FullRowSelect" Value="False"/>
                                <Condition Property="ExpanderPosition" Value="Start"/>
                            </MultiTrigger.Conditions>
                            <Setter Property="Grid.Column" TargetName="BorderContent" Value="2"/>
                            <Setter Property="Grid.ColumnSpan" TargetName="BorderContent" Value="1"/>
                            <Setter Property="Grid.Column" TargetName="PART_HoverBorder" Value="2"/>
                            <Setter Property="Grid.ColumnSpan" TargetName="PART_HoverBorder" Value="1"/>
                        </MultiTrigger>
                        <MultiTrigger>
                            <MultiTrigger.Conditions>
                                <Condition Property="FullRowSelect" Value="False"/>
                                <Condition Property="ExpanderPosition" Value="End"/>
                            </MultiTrigger.Conditions>
                            <Setter Property="Grid.Column" TargetName="BorderContent" Value="0"/>
                            <Setter Property="Grid.ColumnSpan" TargetName="BorderContent" Value="3"/>
                            <Setter Property="Grid.Column" TargetName="PART_HoverBorder" Value="0"/>
                            <Setter Property="Grid.ColumnSpan" TargetName="PART_HoverBorder" Value="3"/>
                        </MultiTrigger>
                        <Trigger Property="ExpanderPosition" Value="Start">
                            <Setter Property="Grid.Column" TargetName="PART_ExpanderView" Value="1"/>
                        </Trigger>
                        <Trigger Property="ExpanderPosition" Value="End">
                            <Setter Property="Grid.Column" TargetName="PART_ExpanderView" Value="3"/>
                        </Trigger>
                        <Trigger Property="ShowLines" Value="True">
                            <Setter Property="Visibility" TargetName="PART_LineGrid" Value="Visible"/>
                        </Trigger>
                        <DataTrigger Binding="{Binding ShowExpanderAnimation}"  Value="True">
                            <Setter Property="ContentTemplate" TargetName="PART_ExpanderView" Value="{StaticResource busyIndicatorTemplate}"/>
                        </DataTrigger>
                        <Trigger Property="IsEnabled" Value="False">
                            <Setter Property="Opacity" Value="0.3"/>
                        </Trigger>
                    </ControlTemplate.Triggers>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
    </Style>
</Window.Resources>
```
![TreeView_Image](TreeView_Image.png)

## Requirements to run the demo
Visual Studio 2015 and above versions


