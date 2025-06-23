<template>
  <v-footer app class="d-flex justify-center align-center" height="60">
    <div class="text-center text-caption">
      <v-btn to="/" variant="text">网站首页</v-btn>
      <v-btn to="/user/feedback" variant="text">反馈留言</v-btn>
      <v-btn to="/author" variant="text">作家专区</v-btn>
      <div class="mt-1">© {{ new Date().getFullYear() }} 小说精品屋</div>
    </div>
  </v-footer>
</template>

<script setup lang="ts">
  //
</script>
