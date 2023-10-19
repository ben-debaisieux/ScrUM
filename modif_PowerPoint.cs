using Microsoft.Office.Interop.PowerPoint;

// Ouvrir le fichier PowerPoint
Application pptApp = new Application();
Presentation presentation = pptApp.Presentations.Open("Chemin_vers_votre_fichier.pptx");

// Insérer une nouvelle diapositive
Slide slide = presentation.Slides.Add(1, PpSlideLayout.ppLayoutText);

// Fermer PowerPoint
presentation.Close();
pptApp.Quit();