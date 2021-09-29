
Public Class Form1

	Dim past_partciple1 As String = "é"
	Dim past_participle2 As String = "i"

	Dim simple_tense_prefixes() As String = {"Je", "Tu", "Il", "Elle", "Nous", "Vous", "Ils", "Elles"}
	Dim passe_compose_prefixes() As String = {"J'ai", "Tu as", "Il a", "Elle a", "Nous avons", "Vous avez", "Ils ont", "Elles ont"}
	Dim plus_que_parfait_prefixes() As String = {"J'avais", "Tu avais", "Il avait", "Elle avait", "Nous avions", "Vous aviez", "Ils avaient", "Elles avaient"}
	Dim passe_anterieur_prefixes() As String = {"J'eu", "Tu eus", "Il eut", "Elle eut", "Nous eûmes", "Vous eûtes", "Ils eurent", "Elles eurent"}
	Dim futur_anterieur_prefixes() As String = {"J'aurai", "Tu auras", "Il aura", "Elle aura", "Nous aurons", "Vous aurez", "Ils auront", "Elles auront"}

	Dim present_suffixes1() As String = {"e", "es", "e", "e", "ons", "ez", "ent", "ent"}
	Dim present_suffixes2() As String = {"i", "is", "i", "i", "issons", "issez", "issent", "issent"}
	Dim imparfait_suffixes1() As String = {"ais", "ais", "ait", "ait", "ions", "iez", "aient", "aient"}
	Dim imparfait_suffixes2() As String = {"issais", "issais", "issait", "issait", "issions", "issiez", "issaient", "issaient"}
	Dim futur_suffixes1() As String = {"erai", "eras", "era", "era", "erons", "erez", "eront", "eront"}
	Dim futur_suffixes2() As String = {"irai", "iras", "ira", "ira", "irons", "irez", "iront", "iront"}
	Dim passe_simple_suffixes1() As String = {"ai", "as", "a", "a", "âmes", "âtes", "èrent", "èrent"}
	Dim passe_simple_suffixes2() As String = {"is", "is", "it", "it", "îmes", "îtes", "irent", "irent"}

	Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles past_tense_table.CellContentClick

	End Sub

	Private Sub Btn_conjuguer_Click(sender As Object, e As EventArgs) Handles Btn_conjuguer.Click
		If (Not (IsNothing(combo_verbe.SelectedItem))) Then
			simple_tense_table.Rows.Clear()
			past_tense_table.Rows.Clear()
			conjuguer_temps_simple(combo_verbe.SelectedItem.ToString)
			conjuguer_temps_compose(combo_verbe.SelectedItem.ToString)
		Else
			MsgBox("Veuillez choisir un verbe et cliquer sur le bouton conjuguer !")
		End If

	End Sub

	Private Sub combo_verbe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_verbe.SelectedIndexChanged

	End Sub
	Sub conjuguer_temps_simple(ByVal verb As String)
		Dim verbe As String = combo_verbe.SelectedItem.ToString
		Dim prefix = verbe.Substring(0, verbe.Length - 2)

		'test if the verb begin by a voyel
		If (is_verb_begin_by_voyel(prefix)) Then
			simple_tense_prefixes(0) = "J'"
		End If



		If (verbe.EndsWith("er")) Then
			Dim i As Integer

			For i = 0 To 7

				simple_tense_table.Rows.Add({
											simple_tense_prefixes(i) + " " + prefix + present_suffixes1(i),
											simple_tense_prefixes(i) + " " + prefix + imparfait_suffixes1(i),
											simple_tense_prefixes(i) + " " + prefix + passe_simple_suffixes1(i),
											simple_tense_prefixes(i) + " " + prefix + futur_suffixes1(i)
											})

			Next
		ElseIf (verbe.EndsWith("ir")) Then
			Dim i As Integer

			For i = 0 To 7

				simple_tense_table.Rows.Add({
											simple_tense_prefixes(i) + " " + prefix + present_suffixes2(i),
											simple_tense_prefixes(i) + " " + prefix + imparfait_suffixes2(i),
											simple_tense_prefixes(i) + " " + prefix + passe_simple_suffixes2(i),
											simple_tense_prefixes(i) + " " + prefix + futur_suffixes2(i)
											})

			Next
		Else

		End If
	End Sub
	Sub conjuguer_temps_compose(ByVal verb As String)
		Dim verbe As String = combo_verbe.SelectedItem.ToString
		Dim prefix = verbe.Substring(0, verbe.Length - 2)
		Dim past_part As String

		If (verbe.EndsWith("er")) Then
			Dim i As Integer
			past_part = prefix + past_partciple1
			For i = 0 To 7

				past_tense_table.Rows.Add({
											passe_compose_prefixes(i) + " " + past_part,
											plus_que_parfait_prefixes(i) + " " + past_part,
											passe_anterieur_prefixes(i) + " " + past_part,
											futur_anterieur_prefixes(i) + " " + past_part
											})

			Next
		ElseIf (verbe.EndsWith("ir")) Then
			Dim i As Integer
			past_part = prefix + past_participle2
			For i = 0 To 7

				past_tense_table.Rows.Add({
											passe_compose_prefixes(i) + " " + past_part,
											plus_que_parfait_prefixes(i) + " " + past_part,
											passe_anterieur_prefixes(i) + " " + past_part,
											futur_anterieur_prefixes(i) + " " + past_part
											})

			Next
		Else

		End If
	End Sub
	Function is_verb_begin_by_voyel(ByVal verb As String) As Integer
		Dim voyels() As String = {"a", "e", "i", "o", "u", "y"}
		Dim res As Boolean
		Dim i As Integer
		res = False
		For i = 0 To 5
			If (String.Compare(voyels(i), verb(0)) = 0) Then
				res = True

			End If
		Next
		is_verb_begin_by_voyel = res
	End Function

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class
