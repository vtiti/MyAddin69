
# MyAddin69

Use the `Debug-adx100` configuration for building the add-in with Add-In Express 10.0, use `Debug-adx94` configuration for building the add-in with Add-In Express 9.4

This addin has 2 RightReading panes and a BottomReading Pane. If in message preview mode the yellow (1) pane visible, if in inline response mode the green (2) pane visible. The bottom orange pane always hidden.

### Reproduction 1

 1. Install the add-in
 2. Start the Outlook. You must see a yellow sidebar (1).
 3. Start a new email. Do nothing, leave the inspector window open. 
 4. Move to the explorer and hover the cursor over the Tasks on the bottom left corner. It will load a preview of your tasks.
 5. **Dang!** Exception happens

### Reproduction 2

 1. Install the add-in
 2. Start the Outlook. You must see a yellow sidebar (1).
 3. Hover the cursor over the Tasks on the bottom left corner. It will load a preview of your tasks.
 4. For a short period of time all panes will be visible (an orange on the bottom, and the arrows to change the side panes)
