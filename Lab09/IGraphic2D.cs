namespace Lab09
{
    
    // Represents a 2D graphical element (e.g., a shape) that can be displayed on the console.
    
    public interface IGraphic2D
    {
       
        // Renders the graphical element to the console using its specified display character and colors.
        
        // True if the graphic was successfully displayed without skipping any part due to console limitations;
        // false if some parts were skipped (e.g., due to buffer size constraints).
       
        bool Display();
    }
}
