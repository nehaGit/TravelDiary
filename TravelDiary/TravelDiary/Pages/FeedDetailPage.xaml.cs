using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiary.Helper;
using Xamarin.Forms;

namespace TravelDiary
{
    public partial class FeedDetailPage : BaseContentPage
    {
        public FeedDetailPage()
        {
            InitializeComponent();
            lblBlog.Text = "Living in Charleston has taught me much more than I ever imagined and has provided me with endless opportunities. I’ve met so many wonderful friends and a great boyfriend, gotten awesome jobs and research positions, began yoga, and discovered an absolutely perfect college major. Since Charleston is the #1 tourist destination and there is nothing I love more than traveling, I decided to major in Hospitality and Tourism Management – which is a great way to ensure I can work in a stable and quickly growing industry, while being able to travel and live in some of the best cities in the world. Both the college and my department have provided me with numerous study abroad opportunities. After all, CofC ranked #4 in the U.S. for college study abroad programs! I have already participated in two spring break study abroad programs to Berlin and Dubai, and now I will be in Florence, Italy for the semester.";

            BindingContext = new SwitcherPageViewModel();
            var pagesCarousel = Carousel.CreatePagesCarousel();
            var dots = Carousel.CreatePagerIndicatorContainer();
            cLayout.Children.Add(pagesCarousel,
                        Constraint.RelativeToParent((parent) => { return parent.X; }),
                        Constraint.RelativeToParent((parent) => { return parent.Y; }),
                        Constraint.RelativeToParent((parent) => { return parent.Width; }),
                        Constraint.Constant(220)
                    );

            cLayout.Children.Add(dots,
                        Constraint.Constant(0),
                        Constraint.RelativeToView(pagesCarousel,
                            (parent, sibling) => { return sibling.Height - 18; }),
                        Constraint.RelativeToParent(parent => parent.Width),
                        Constraint.Constant(18)
                    );
        }
    }
}
