using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01_FaceBook
{
    public partial class FaceBookMainForm
    {
        private void ButtonMatchFinder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format(
                "Gender: {0}\n" +
                "Min age: {1}\n" +
                "Max age: {2}\n",comboBoxMatchGender.SelectedItem.ToString(),
                numericUpDownMinAge.Value.ToString(),
                numericUpDownMaxAge.Value.ToString()
                ));
            
            foreach(User friend in m_LoggedInUser.Friends)
            {
                if((comboBoxMatchGender.SelectedItem.ToString().ToLower() == "both" ||
                    friend.Gender.ToString().ToLower() == comboBoxMatchGender.SelectedItem.ToString().ToLower())
                    &&
                    (friend.RelationshipStatus == User.eRelationshipStatus.Widowed ||
                    friend.RelationshipStatus == User.eRelationshipStatus.Single ||
                    friend.RelationshipStatus == User.eRelationshipStatus.Separated ||
                    friend.RelationshipStatus == User.eRelationshipStatus.Divorced)
                    &&
                    (friend.InterestedIn == m_LoggedInUser.Gender)
                    )
            }
        }
    }
}
