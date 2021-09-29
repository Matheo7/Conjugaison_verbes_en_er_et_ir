<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form remplace la méthode Dispose pour nettoyer la liste des composants.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Requise par le Concepteur Windows Form
	Private components As System.ComponentModel.IContainer

	'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
	'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
	'Ne la modifiez pas à l'aide de l'éditeur de code.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.combo_verbe = New System.Windows.Forms.ComboBox()
        Me.simple_tense_table = New System.Windows.Forms.DataGridView()
        Me.present = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imparfait = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.passe_simple = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.futur_simple = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.past_tense_table = New System.Windows.Forms.DataGridView()
        Me.passe_compose = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plus_que_parfait = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.futur_anterieur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.passe_anterieur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_conjuguer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.simple_tense_table, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.past_tense_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'combo_verbe
        '
        Me.combo_verbe.AutoCompleteCustomSource.AddRange(New String() {"abaisser", "abandonner", "abdiquer", "aberrer", "abhorrer", "abjurer", "ablater", "abloquer", "abominer", "abonder", "abonner", "aborder", "aboucher", "abouler", "abouter", "abraser", "abreuver", "abricoter", "abriter", "absenter", "absorber", "abuser", "acagnarder", "accabler", "accaparer", "accastiller", "accentuer", "accepter", "acclamer", "acclimater", "accointer", "accoler", "accommoder", "accompagner", "accorder", "accorer", "accoster", "accoter", "accoucher", "accoupler", "accoutrer", "accoutumer", "accrocher", "acculer", "acculturer", "accumuler", "accuser", "acenser", "achalander", "achaler", "acharner", "acheminer", "acheter", "achever", "achopper", "achromatiser", "acidifier", "aciduler", "aciseler", "acoquiner", "acquitter", "acter", "actionner", "activer", "actualiser", "adapter", "additionner", "adhérer", "adirer", "adjectiver", "adjectiviser", "adjurer", "administrer", "admirer", "admonester", "adoniser", "adonner", "adopter", "adorer", "adosser", "adouber", "adresser", "adsorber", "aduler", "affabuler", "affaisser", "affaler", "affecter", "affectionner", "affermer", "afficher", "affiler", "affilier", "affiner", "affirmer", "affleurer", "affluer", "affoler", "affouiller", "affourager", "affourcher", "affriander", "affricher", "affrioler", "affriter", "affronter", "affruiter", "affubler", "affurer", "africaniser", "agacer", "agencer", "agender", "agglutiner", "aggraver", "agioter", "agiter", "agneler", "agoniser", "agrafer", "agrainer", "agresser", "agricher", "agriffer", "agripper", "aguicher", "ahaner", "aheurter", "aider", "aiguilleter", "aiguillonner", "aiguiser", "aimanter", "aimer", "ajointer", "ajourer", "ajourner", "ajouter", "ajuster", "alambiquer", "alarmer", "alcaliniser", "alcaliser", "alcooliser", "alerter", "aleviner", "aligner", "alimenter", "aliter", "allaiter", "allier", "allonger", "allouer", "allumer", "alluvionner", "alterner", "aluminer", "aluner", "amalgamer", "amariner", "amarrer", "amasser", "ambiancer", "ambifier", "ambitionner", "ambler", "ambrer", "amender", "amener", "amenuiser", "ameuter", "amidonner", "aminer", "amnistier", "amocher", "amodier", "amonceler", "amorcer", "amordancer", "amouracher", "amourer", "amplifier", "amputer", "amurer", "amuser", "améliorer", "aménager", "américaniser", "analyser", "anastomoser", "anatomiser", "animer", "aniser", "ankyloser", "anneler", "annexer", "annoncer", "abasourdir", "ablatir", "abolir", "abonnir", "aboutir", "abrutir", "abréagir", "accomplir", "accourcir", "accroupir", "adoucir", "affadir", "affaiblir", "affermir", "affranchir", "agir", "agonir", "agrandir", "aguerrir", "ahurir", "aigrir", "alanguir", "alentir", "allégir", "alourdir", "alunir", "amaigrir", "amatir", "amerrir", "ameublir", "amincir", "amoindrir", "amollir", "amortir", "anéantir", "aplanir", "aplatir", "appauvrir", "appesantir", "applaudir", "approfondir", "arrondir", "assainir", "asservir", "assombrir", "assortir", "assoupir", "assouplir", "assourdir", "assujettir", "atterrir", "avertir", "avilir", "bannir", "blanchir", "bleuir", "bondir", "bénir", "choisir", "chérir", "compatir", "convertir", "croupir", "crépir", "dessaisir", "dessertir", "divertir", "durcir", "décrépir", "définir", "défleurir", "défléchir", "déguerpir", "démolir", "démunir", "dénantir", "dépolir", "désinvestir", "dévernir", "embellir", "engloutir", "engourdir", "enhardir", "enorgueillir", "enrichir", "ensevelir", "envahir", "finir", "fleurir", "fléchir", "flétrir", "fournir", "franchir", "garantir", "garnir", "grandir", "gravir", "grossir", "interagir", "intervertir", "invertir", "investir", "jaillir", "jaunir", "jouir", "maigrir", "munir", "noircir", "nourrir", "polir", "pourrir", "prémunir", "préétablir", "punir", "rabonnir", "rabougrir", "raccourcir", "racornir", "radoucir", "raffermir", "ravir", "reblanchir", "rebondir", "reconvertir", "redéfinir", "redémolir", "refleurir", "refroidir", "regrossir", "rejaillir", "rembrunir", "remplir", "renchérir", "renformir", "repolir", "resplendir", "ressaisir", "ressurgir", "retentir", "reverdir", "revernir", "rougir", "réagir", "réfléchir", "régir", "réinvestir", "réjouir", "rélargir", "rétablir", "rétroagir", "rétrécir", "réunir", "réussir", "saisir", "salir", "saurir", "serfouir", "sertir", "subir", "subvertir", "superfinir", "surenchérir", "surgir", "tarir", "tartir", "ternir", "terrir", "trahir", "transir", "travestir", "unir", "vagir", "verdir", "vernir", "vieillir", "vomir", "éclaircir", "élargir", "épanouir", "établir", "étourdir", "étrécir", "ébahir", "ébaubir", "ébaudir", "éclaircir", "élargir", "épaissir", "épanouir", "établir", "étourdir", "étrécir", "évanouir", "rabonnir", "rabougrir", "raccourcir", "racornir", "radoucir"})
        Me.combo_verbe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.combo_verbe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_verbe.FormattingEnabled = True
        Me.combo_verbe.Items.AddRange(New Object() {"abaisser", "abandonner", "abdiquer", "aberrer", "abhorrer", "abjurer", "ablater", "abloquer", "abominer", "abonder", "abonner", "aborder", "aboucher", "abouler", "abouter", "abraser", "abreuver", "abricoter", "abriter", "absenter", "absorber", "abuser", "acagnarder", "accabler", "accaparer", "accastiller", "accentuer", "accepter", "acclamer", "acclimater", "accointer", "accoler", "accommoder", "accompagner", "accorder", "accorer", "accoster", "accoter", "accoucher", "accoupler", "accoutrer", "accoutumer", "accrocher", "acculer", "acculturer", "accumuler", "accuser", "acenser", "achalander", "achaler", "acharner", "acheminer", "acheter", "achever", "achopper", "achromatiser", "acidifier", "aciduler", "aciseler", "acoquiner", "acquitter", "acter", "actionner", "activer", "actualiser", "adapter", "additionner", "adhérer", "adirer", "adjectiver", "adjectiviser", "adjurer", "administrer", "admirer", "admonester", "adoniser", "adonner", "adopter", "adorer", "adosser", "adouber", "adresser", "adsorber", "aduler", "affabuler", "affaisser", "affaler", "affecter", "affectionner", "affermer", "afficher", "affiler", "affilier", "affiner", "affirmer", "affleurer", "affluer", "affoler", "affouiller", "affourager", "affourcher", "affriander", "affricher", "affrioler", "affriter", "affronter", "affruiter", "affubler", "affurer", "africaniser", "agacer", "agencer", "agender", "agglutiner", "aggraver", "agioter", "agiter", "agneler", "agoniser", "agrafer", "agrainer", "agresser", "agricher", "agriffer", "agripper", "aguicher", "ahaner", "aheurter", "aider", "aiguilleter", "aiguillonner", "aiguiser", "aimanter", "aimer", "ajointer", "ajourer", "ajourner", "ajouter", "ajuster", "alambiquer", "alarmer", "alcaliniser", "alcaliser", "alcooliser", "alerter", "aleviner", "aligner", "alimenter", "aliter", "allaiter", "allier", "allonger", "allouer", "allumer", "alluvionner", "alterner", "aluminer", "aluner", "amalgamer", "amariner", "amarrer", "amasser", "ambiancer", "ambifier", "ambitionner", "ambler", "ambrer", "amender", "amener", "amenuiser", "ameuter", "amidonner", "aminer", "amnistier", "amocher", "amodier", "amonceler", "amorcer", "amordancer", "amouracher", "amourer", "amplifier", "amputer", "amurer", "amuser", "améliorer", "aménager", "américaniser", "analyser", "anastomoser", "anatomiser", "animer", "aniser", "ankyloser", "anneler", "annexer", "annoncer", "abasourdir", "ablatir", "abolir", "abonnir", "aboutir", "abrutir", "abréagir", "accomplir", "accourcir", "accroupir", "adoucir", "affadir", "affaiblir", "affermir", "affranchir", "agir", "agonir", "agrandir", "aguerrir", "ahurir", "aigrir", "alanguir", "alentir", "allégir", "alourdir", "alunir", "amaigrir", "amatir", "amerrir", "ameublir", "amincir", "amoindrir", "amollir", "amortir", "anéantir", "aplanir", "aplatir", "appauvrir", "appesantir", "applaudir", "approfondir", "arrondir", "assainir", "asservir", "assombrir", "assortir", "assoupir", "assouplir", "assourdir", "assujettir", "atterrir", "avertir", "avilir", "bannir", "blanchir", "bleuir", "bondir", "bénir", "choisir", "chérir", "compatir", "convertir", "croupir", "crépir", "dessaisir", "dessertir", "divertir", "durcir", "décrépir", "définir", "défleurir", "défléchir", "déguerpir", "démolir", "démunir", "dénantir", "dépolir", "désinvestir", "dévernir", "embellir", "engloutir", "engourdir", "enhardir", "enorgueillir", "enrichir", "ensevelir", "envahir", "finir", "fleurir", "fléchir", "flétrir", "fournir", "franchir", "garantir", "garnir", "grandir", "gravir", "grossir", "interagir", "intervertir", "invertir", "investir", "jaillir", "jaunir", "jouir", "maigrir", "munir", "noircir", "nourrir", "polir", "pourrir", "prémunir", "préétablir", "punir", "rabonnir", "rabougrir", "raccourcir", "racornir", "radoucir", "raffermir", "ravir", "reblanchir", "rebondir", "reconvertir", "redéfinir", "redémolir", "refleurir", "refroidir", "regrossir", "rejaillir", "rembrunir", "remplir", "renchérir", "renformir", "repolir", "resplendir", "ressaisir", "ressurgir", "retentir", "reverdir", "revernir", "rougir", "réagir", "réfléchir", "régir", "réinvestir", "réjouir", "rélargir", "rétablir", "rétroagir", "rétrécir", "réunir", "réussir", "saisir", "salir", "saurir", "serfouir", "sertir", "subir", "subvertir", "superfinir", "surenchérir", "surgir", "tarir", "tartir", "ternir", "terrir", "trahir", "transir", "travestir", "unir", "vagir", "verdir", "vernir", "vieillir", "vomir", "éclaircir", "élargir", "épanouir", "établir", "étourdir", "étrécir", "ébahir", "ébaubir", "ébaudir", "éclaircir", "élargir", "épaissir", "épanouir", "établir", "étourdir", "étrécir", "évanouir", "rabonnir", "rabougrir", "raccourcir", "racornir", "radoucir"})
        Me.combo_verbe.Location = New System.Drawing.Point(217, 98)
        Me.combo_verbe.Name = "combo_verbe"
        Me.combo_verbe.Size = New System.Drawing.Size(184, 21)
        Me.combo_verbe.TabIndex = 0
        '
        'simple_tense_table
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.simple_tense_table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.simple_tense_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.simple_tense_table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.present, Me.imparfait, Me.passe_simple, Me.futur_simple})
        Me.simple_tense_table.Location = New System.Drawing.Point(12, 248)
        Me.simple_tense_table.Name = "simple_tense_table"
        Me.simple_tense_table.ReadOnly = True
        Me.simple_tense_table.Size = New System.Drawing.Size(507, 197)
        Me.simple_tense_table.TabIndex = 1
        '
        'present
        '
        Me.present.HeaderText = "Présent"
        Me.present.Name = "present"
        Me.present.ReadOnly = True
        '
        'imparfait
        '
        Me.imparfait.HeaderText = "Imparfait"
        Me.imparfait.Name = "imparfait"
        Me.imparfait.ReadOnly = True
        '
        'passe_simple
        '
        Me.passe_simple.HeaderText = "Passé Simple"
        Me.passe_simple.Name = "passe_simple"
        Me.passe_simple.ReadOnly = True
        '
        'futur_simple
        '
        Me.futur_simple.HeaderText = "Futur Simple"
        Me.futur_simple.Name = "futur_simple"
        Me.futur_simple.ReadOnly = True
        '
        'past_tense_table
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.past_tense_table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.past_tense_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.past_tense_table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.passe_compose, Me.plus_que_parfait, Me.futur_anterieur, Me.passe_anterieur})
        Me.past_tense_table.Location = New System.Drawing.Point(537, 248)
        Me.past_tense_table.Name = "past_tense_table"
        Me.past_tense_table.ReadOnly = True
        Me.past_tense_table.Size = New System.Drawing.Size(510, 197)
        Me.past_tense_table.TabIndex = 2
        '
        'passe_compose
        '
        Me.passe_compose.HeaderText = "Passé Composé"
        Me.passe_compose.Name = "passe_compose"
        Me.passe_compose.ReadOnly = True
        '
        'plus_que_parfait
        '
        Me.plus_que_parfait.HeaderText = "Plus Que Parfait"
        Me.plus_que_parfait.Name = "plus_que_parfait"
        Me.plus_que_parfait.ReadOnly = True
        '
        'futur_anterieur
        '
        Me.futur_anterieur.HeaderText = "Passé Antérieur"
        Me.futur_anterieur.Name = "futur_anterieur"
        Me.futur_anterieur.ReadOnly = True
        '
        'passe_anterieur
        '
        Me.passe_anterieur.HeaderText = "Futur Antérieur"
        Me.passe_anterieur.Name = "passe_anterieur"
        Me.passe_anterieur.ReadOnly = True
        '
        'Btn_conjuguer
        '
        Me.Btn_conjuguer.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_conjuguer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_conjuguer.Location = New System.Drawing.Point(513, 98)
        Me.Btn_conjuguer.Name = "Btn_conjuguer"
        Me.Btn_conjuguer.Size = New System.Drawing.Size(268, 52)
        Me.Btn_conjuguer.TabIndex = 3
        Me.Btn_conjuguer.Text = "Conjuguer"
        Me.Btn_conjuguer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(12, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Temps Simples"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(533, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Temps Composés"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(12, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Choisir un verbe ->"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 506)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_conjuguer)
        Me.Controls.Add(Me.past_tense_table)
        Me.Controls.Add(Me.simple_tense_table)
        Me.Controls.Add(Me.combo_verbe)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.simple_tense_table, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.past_tense_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents combo_verbe As ComboBox
	Friend WithEvents simple_tense_table As DataGridView
	Friend WithEvents present As DataGridViewTextBoxColumn
	Friend WithEvents imparfait As DataGridViewTextBoxColumn
	Friend WithEvents passe_simple As DataGridViewTextBoxColumn
	Friend WithEvents futur_simple As DataGridViewTextBoxColumn
	Friend WithEvents past_tense_table As DataGridView
    Friend WithEvents Btn_conjuguer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents passe_compose As DataGridViewTextBoxColumn
    Friend WithEvents plus_que_parfait As DataGridViewTextBoxColumn
    Friend WithEvents futur_anterieur As DataGridViewTextBoxColumn
    Friend WithEvents passe_anterieur As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
End Class
